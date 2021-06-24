using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationSystemManager.Controller;

namespace VaccinationSystemManager.Views
{
    public partial class frmVerifyCitizen : Form
    {
        frmDashboard dashboard;
        public frmVerifyCitizen(frmDashboard dash)
        {
            dashboard = dash;
            InitializeComponent();
        }

        private void txtVerifyCitizenDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnVerifyCitizenSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DuiHandler duiValidator = new DuiHandler(null, txtVerifyCitizenDUI);

                duiValidator.Validate();

                string dui = txtVerifyCitizenDUI.Text;

                var db = new Model.G4ProyectoDBContext();

                var countUser = UserInformation.CheckExistence(dui);

                //Check if user has an appointment based on counter
                if (countUser >= 1)
                {
                    bool alreadyVaccinated = true;

                    Model.Citizen newCitizen = new Model.Citizen();

                    newCitizen = db.Citizens
                        .Where(u => u.Dui == dui)
                        .FirstOrDefault();

                    Model.Appointment checkAppointment = new Model.Appointment();

                    //Check for shot type 1 based on counter
                    if (countUser == 1)
                    {
                        checkAppointment = db.Appointments
                            .Where(u => u.DuiCitizen == newCitizen.Dui)
                            .Where(u => u.ShotType == 1)
                            .FirstOrDefault();

                        //check vaccine
                        var countVaccine = db.VaccinationProcesses
                            .Where(u => u.DuiCitizen == newCitizen.Dui)
                            .Where(u => u.ShotType == 1)
                            .Count();

                        if (countVaccine == 0)
                        {
                            alreadyVaccinated = false;
                        }
                    }

                    //Check for shot type 2 based on counter
                    if (countUser == 2)
                    {
                        checkAppointment = db.Appointments
                            .Where(u => u.DuiCitizen == newCitizen.Dui)
                            .Where(u => u.ShotType == 2)
                            .FirstOrDefault();

                        //check vaccine
                        var countVaccine = db.VaccinationProcesses
                            .Where(u => u.DuiCitizen == newCitizen.Dui)
                            .Where(u => u.ShotType == 2)
                            .Count();

                        if (countVaccine == 0)
                        {
                            alreadyVaccinated = false;
                        }
                    }

                    //Verify if the user has alredy been vaccinated
                    if (alreadyVaccinated == false)
                    {
                        var days = ((DateTime.Now - checkAppointment.AppointmentDate).Days);

                        //Day of the appointment
                        if (days == 0)
                        {
                            var hours = ((checkAppointment.AppointmentDate - DateTime.Now).Hours);

                            //Exact hour or a later
                            if (hours <= 0)
                            {
                                //Start Vaccination Process
                                frmStartVaccinationProcess StartVaccination = new frmStartVaccinationProcess(newCitizen, checkAppointment, dashboard);
                                StartVaccination.Show();

                                this.Hide();

                                //this.Close();
                            }
                            //Too early (hours > 0)
                            else
                            {
                                var minutes = ((DateTime.Now - checkAppointment.AppointmentDate).Minutes);

                                MessageBox.Show($"La cita iniciará dentro de {hours} horas, es necesario esperar este tiempo para iniciar el proceso de vacunación",
                                "Vacunación COVID-19",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        //Not yet the date of the appointment
                        else if (days < 0)
                        {
                            MessageBox.Show($"La cita está agendada dentro de {(days * -1)} días, aún no puede iniciar el proceso de vacunación",
                                "Vacunación COVID-19",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        //The day of the appointment has passed (days > 0)
                        else
                        {
                            MessageBox.Show($"La cita caducó hace {days} días, es necesario agendar una nueva cita para iniciar el proceso de vacunación",
                                "Vacunación COVID-19",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Delete previus appointment in order to avoid future confilcs
                            db.Remove(db.Appointments.SingleOrDefault(u => u.Id == checkAppointment.Id));
                            db.SaveChanges();

                            // returns to "register appointment" form
                            frmAppointmentProcess appointmentClient = new frmAppointmentProcess(dashboard);
                            appointmentClient.Show();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"El ciudadano ya ha sido vacunado con anterioridad, dosis tipo: {checkAppointment.ShotType}",
                        "Vacunación COVID-19",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El ciudadano no cuenta con ninguna cita registada, es necesario agendar una cita para iniciar el proceso de vacunación",
                        "Vacunación COVID-19",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // returns to "register appointment" form
                    frmAppointmentProcess appointmentClient = new frmAppointmentProcess(dashboard);
                    appointmentClient.Show();
                    Close();
                }
            }
            catch(FormInputException ex)
            {
                epVerify.SetError(ex.errorTarget, ex.Message);
            }
            
        }

        private void btnVerifyCitizenCancel_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }

        private void btnVerifyCitizenSearch_Leave(object sender, EventArgs e)
        {
            epVerify.Clear();
        }
    }
}
