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

                Model.Citizen newCitizen = new Model.Citizen();

                newCitizen = db.Citizens
                    .Where(u => u.Dui == dui)
                    .FirstOrDefault();

                var countUser = UserInformation.CheckExistence(dui);

                Model.Appointment checkAppointment = new Model.Appointment();

                //Check if user has an appointment based on counter
                if (countUser >= 1)
                {
                    //Check for shot type 1 based on counter
                    if (countUser == 1)
                    {
                        checkAppointment = db.Appointments
                            .Where(u => u.DuiCitizen == newCitizen.Dui)
                            .Where(u => u.ShotType == 1)
                            .FirstOrDefault();
                    }

                    //Check for shot type 2 based on counter
                    if (countUser == 2)
                    {
                        checkAppointment = db.Appointments
                            .Where(u => u.DuiCitizen == newCitizen.Dui)
                            .Where(u => u.ShotType == 2)
                            .FirstOrDefault();
                    }

                    // go to AppointmentProcessDetails
                    frmAppointmentProcessDetails appointmentDetails = new frmAppointmentProcessDetails(checkAppointment, dashboard);
                    appointmentDetails.Show();
                    Close();
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
