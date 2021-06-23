using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaccinationSystemManager.Views
{
    public partial class frmStartVaccinationProcess : Form
    {
        private Model.Citizen vaccinationCitizen = new Model.Citizen();
        private Model.Appointment vaccinationAppointment = new Model.Appointment();
        private Model.DoseType vaccinationDose = new Model.DoseType();

        public frmStartVaccinationProcess(Model.Citizen citizen, Model.Appointment appointment)
        {
            InitializeComponent();

            //Initialize data
            vaccinationCitizen = citizen;
            vaccinationAppointment = appointment;

            //Assign data to txt
            txtStartVaccinationDUI.Text = vaccinationCitizen.Dui;
            txtStartVaccinationName.Text = vaccinationCitizen.CitizenName;
            txtStartVaccinationAddress.Text = vaccinationCitizen.CitizenAddress;
            txtStartVaccinationPhone.Text = vaccinationCitizen.PhoneNumber;
            txtStartVaccinationMail.Text = vaccinationCitizen.EMail;
            txtStartVaccinationIdentifier.Text = vaccinationCitizen.IdentifierNumber;

            //Select Dose type from db
            var db = new Model.G4ProyectoDBContext();
            
            vaccinationDose = db.DoseTypes
                .Where(u => u.Id == vaccinationAppointment.ShotType)
                .FirstOrDefault();

            txtStartVaccinationDose.Text = vaccinationDose.ShotType;
            
            dtpStartVaccinationDate.Value = DateTime.Now;
            dtpStartVaccinationStart.Value = DateTime.Now;
            dtpStartVaccinationVaccine.Value = DateTime.Now;
            dtpStartVaccinationEnd.Value = DateTime.Now;
        }

        private void btnVerifyCitizenSearch_Click(object sender, EventArgs e)
        {
            var minutesFromStartToVaccine = ((dtpStartVaccinationStart.Value - dtpStartVaccinationVaccine.Value).Minutes);

            //Verify timer
            if (dtpStartVaccinationStart.Value <= dtpStartVaccinationVaccine.Value)
            {
                if ((dtpStartVaccinationVaccine.Value < dtpStartVaccinationEnd.Value) && ((((dtpStartVaccinationVaccine.Value - dtpStartVaccinationEnd.Value).Minutes >= -30)) || (((dtpStartVaccinationVaccine.Value - dtpStartVaccinationEnd.Value).Hours >= 0))))
                {
                    DateTime vaccineDay = dtpStartVaccinationDate.Value;
                    TimeSpan vaccineStart = dtpStartVaccinationStart.Value.TimeOfDay;
                    TimeSpan vaccineShot = dtpStartVaccinationVaccine.Value.TimeOfDay;
                    TimeSpan vaccineEnd = dtpStartVaccinationEnd.Value.TimeOfDay;

                    Model.VaccinationProcess vaccinationProcess = new Model.VaccinationProcess()
                    {
                        VaccinationDate = vaccineDay,
                        StartTiem = vaccineStart,
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
                        MessageBox.Show("Proceso de vacunación registrado correctamente",
                            "Vacunación COVID-19",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Check if it's necesary to schedule a new appointment for dose 2
                        if (vaccinationProcess.ShotType == 1)
                        {
                            MessageBox.Show("Agendando cita para la segunda dosis",
                            "Vacunación COVID-19",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Proceso de agenda
                            //Devolver al Dashboard
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                            //Devolver al Dashboard
                        }
                    }
                    else
                    {
                        //Create an Side Effect form
                        frmSideEffects VaccineSideEffect = new frmSideEffects(vaccinationProcess);
                        VaccineSideEffect.Show();
                        
                        this.Close();
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
            this.Close();
            //Devolver al Dashboard
        }
    }
}
