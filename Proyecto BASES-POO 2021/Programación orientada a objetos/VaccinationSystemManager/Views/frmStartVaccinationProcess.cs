using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationSystemManager.Controller.AppointmentController;
using VaccinationSystemManager.Controller;

namespace VaccinationSystemManager.Views
{
    public partial class frmStartVaccinationProcess : Form
    {
        frmDashboard dashboard;
        private Model.Citizen vaccinationCitizen = new Model.Citizen();
        private Model.Appointment vaccinationAppointment = new Model.Appointment();
        private Model.DoseType vaccinationDose = new Model.DoseType();

        public frmStartVaccinationProcess(Model.Citizen citizen, Model.Appointment appointment, frmDashboard dash)
        {
            InitializeComponent();

            dashboard = dash;

            //Initialize data
            vaccinationCitizen = citizen;
            vaccinationAppointment = appointment;
        }

        private void frmStartVaccinationProcess_Load(object sender, EventArgs e)
        {
            //Assign data to txt
            lblDui.Text = vaccinationCitizen.Dui;
            lblCitizenName.Text = vaccinationCitizen.CitizenName;
            lblAddress.Text = vaccinationCitizen.CitizenAddress;
            lblPhoneNumber.Text = vaccinationCitizen.PhoneNumber;

            if(vaccinationCitizen.EMail == null)
            {
                lblEMail.Text = "No posee correo electrónico";
            }
            else
            {
                lblEMail.Text = vaccinationCitizen.EMail;
            }

            var db = new Model.G4ProyectoDBContext();

            // recovers the dose type from database
            vaccinationDose = db.DoseTypes
                .Where(u => u.Id == vaccinationAppointment.ShotType)
                .FirstOrDefault();

            lblDoseType.Text = vaccinationDose.ShotType;

            // set identifier number in label
            if(vaccinationCitizen.IdentifierNumber == null)
            {
                lblIdentifiationNumber.Text = "No pertenece a una institución esencial";
            }
            else
            {
                lblIdentifiationNumber.Text = vaccinationCitizen.IdentifierNumber;
            }

            // recovers the diseasies from database
            var diseasies = db.Diseases
                .Where(d => d.DuiCitizen == vaccinationAppointment.DuiCitizen)
                .ToList();

            if( diseasies.Count > 0)
            {
                cmbDiseasies.Visible = true;
                cmbDiseasies.DataSource = diseasies;
                cmbDiseasies.DisplayMember = "DiseaseName";
            }
            else
            {
                lblDiseasies.Visible = true;
            }

            // recovers the disabilities from database
            var disabilities = db.Disabilities
                .Where(d => d.DuiCitizen == vaccinationAppointment.DuiCitizen)
                .ToList();

            if (disabilities.Count > 0)
            {
                cmbDisabilities.Visible = true;
                cmbDisabilities.DataSource = disabilities;
                cmbDisabilities.DisplayMember = "DisabilityName";
            }
            else
            {
                lblDisabilities.Visible = true;
            }
            
            lblVaccinationDate.Text = vaccinationAppointment.AppointmentDate.ToString("dd-MM-yyyy");
            dtpStartVaccinationDate.Value = DateTime.Now;
            dtpStartVaccinationVaccine.Value = DateTime.Now;
            dtpStartVaccinationEnd.Value = DateTime.Now;
        }

        private void btnStarVaccinationSave_Click(object sender, EventArgs e)
        {
            var minutesFromStartToVaccine = ((dtpStartVaccinationDate.Value - dtpStartVaccinationVaccine.Value).Minutes);

            //Verify timer
            if (dtpStartVaccinationDate.Value <= dtpStartVaccinationVaccine.Value)
            {
                if ((dtpStartVaccinationVaccine.Value < dtpStartVaccinationEnd.Value) && ((((dtpStartVaccinationVaccine.Value - dtpStartVaccinationEnd.Value).Minutes >= -30)) || (((dtpStartVaccinationVaccine.Value - dtpStartVaccinationEnd.Value).Hours >= 0))))
                {
                    DateTime vaccineDay = dtpStartVaccinationDate.Value;
                    TimeSpan vaccineStart = dtpStartVaccinationDate.Value.TimeOfDay;
                    TimeSpan vaccineShot = dtpStartVaccinationVaccine.Value.TimeOfDay;
                    TimeSpan vaccineEnd = dtpStartVaccinationEnd.Value.TimeOfDay;

                    Model.VaccinationProcess vaccinationProcess = new Model.VaccinationProcess()
                    {
                        VaccinationDate = vaccineDay,
                        StartTime = vaccineStart,
                        VaccinationTime = vaccineShot,
                        EndTime = vaccineEnd,
                        ShotType = vaccinationDose.Id,
                        DuiCitizen = vaccinationCitizen.Dui
                    };

                    var db = new Model.G4ProyectoDBContext();

                    db.VaccinationProcesses.Add(vaccinationProcess);
                    db.SaveChanges();

                    //Check Side Effects
                    DialogResult result = MessageBox.Show("¿El paciente presentó efectos secundarios?",
                        "Vacunación COVID-19",
                        MessageBoxButtons.YesNo);
                    
                    if (result == DialogResult.No)
                    {
                        //Check if it's necesary to schedule a new appointment for second dose
                        if (vaccinationProcess.ShotType == 1)
                        {
                            AppointmentProxy appointmentManager = new AppointmentProxy(db);

                            DateTime appointmentDate = appointmentManager.GenerateDate(UserInformation.GetVaccinationCenter(vaccinationAppointment.IdCenter), UserInformation.GetDoseType(2));

                            Model.Appointment newAppointment = appointmentManager.MakeAppointment(
                                                                                            UserInformation.GetDoseType(2),
                                                                                            UserInformation.GetCitizen(vaccinationAppointment.DuiCitizen),
                                                                                            dashboard.LoggedEmployee,
                                                                                            vaccinationAppointment.IdCenter,
                                                                                            appointmentDate
                                                                                         );

                            // returns to appointment details form
                            frmAppointmentProcessDetails details = new frmAppointmentProcessDetails(newAppointment, dashboard);
                            details.Show();
                            Close();
                        }
                        else
                        {
                            // returns to dashboard
                            dashboard.Show();
                            Close();
                        }
                    }
                    else
                    {
                        //Create an Side Effect form
                        frmSideEffects VaccineSideEffect = new frmSideEffects(vaccinationAppointment, vaccinationProcess, dashboard);
                        VaccineSideEffect.Show();
                        
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Como mínimo, debieron pasar 30 minutos entre de la hora de vacunación y la hora de finalización",
                            "Vacunación COVID-19",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("La hora de vacunación no puede ser antes de la hora de inicio",
                        "Vacunación COVID-19",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerifyCitizenCancel_Click(object sender, EventArgs e)
        {
            //Returns to Dashboard
            dashboard.Show();
            Close();
        }
    }
}
