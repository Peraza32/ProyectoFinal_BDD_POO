using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccinationSystemManager.Model;
using VaccinationSystemManager.Controller;
using VaccinationSystemManager.Controller.AppointmentController;

namespace VaccinationSystemManager.Views
{
    public partial class frmAppointmentProcess : Form
    {
        frmDashboard dashboard;
        public frmAppointmentProcess(frmDashboard lastForm)
        {
            dashboard = lastForm;
            InitializeComponent();
        }

        private void frmAppointmentProcess_Load(object sender, EventArgs e)
        {

        }

        // Limits that the user can only enter numbers or delete
        // in the textbox corresponding to the Dui
        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Limits that the user can only enter numbers or delete
        // in the textbox corresponding to phone number
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var db = new G4ProyectoDBContext();

            // stores the dui of the citizen
            string dui = txtDui.Text;

            // stores the name of the citizen
            string name = txtName.Text;

            // stores the birth date of the citizen
            DateTime birthDate = dtpBirthDate.Value;

            // age of the citizen
            var years = ((DateTime.Now - birthDate).Days) / 365;

            // flag variable that indicates if the citizen
            // can be vaccinated
            bool canBeVaccinated;

            // Es mayor de 18 años
            if (years >= 18)
            {
                // Tiene alguna enfermedad crónica
                if (txtDiseases.TextLength > 0)
                    canBeVaccinated = true;
                // No tiene enfermedad crónica
                else
                {
                    // Tiene alguna discapacidad
                    if (txtDisabilities.TextLength > 0)
                        canBeVaccinated = true;
                    // No tiene discapacidad
                    else
                    {
                        // Pertenece a un grupo especial (Personal médico, PNC, Fuerza Armada, etc.)
                        if (txtEssentialInstitution.TextLength > 0)
                            canBeVaccinated = true;
                        // No pertenece a un grupo especial
                        else
                        {
                            // Es mayor de 60 años
                            if (years >= 60)
                                canBeVaccinated = true;
                            // No es mayor de 60 años
                            else
                                // No es apto para ser vacunado
                                canBeVaccinated = false;

                        }
                    }
                }
            }
            // Es menor de 18 años (no es apto para ser vacunado)
            else
            {
                canBeVaccinated = false;
            }

            // Ya hemos validado si el usuario pertenece a un grupo prioritario
            // y determinamos si puede ser vacunado
            if (canBeVaccinated)
            {
                string addres = txtAddres.Text;
                string phoneNumber = txtPhoneNumber.Text;

                Citizen newCitizen = new Citizen
                {
                    Dui = dui,
                    CitizenName = name,
                    CitizenAddress = addres,
                    PhoneNumber = phoneNumber
                };

                if (txtEMail.TextLength > 0)
                {
                    string email = txtEMail.Text;
                    newCitizen.EMail = email;
                }
                else
                {
                    newCitizen.EMail = null;
                }

                if (txtEssentialInstitution.TextLength > 0)
                {
                    string identifierNumber = txtEssentialInstitution.Text;
                    newCitizen.IdentifierNumber = identifierNumber;
                }
                else
                {
                    newCitizen.IdentifierNumber = null;
                }

                // saves the new citizen in the database
                db.Citizens.Add(newCitizen);
                db.SaveChanges();

                 // Tiene alguna enfermedad crónica
                 if(txtDiseases.TextLength > 0)
                 {
                    // obtains all diseases of the citizen
                    string diseasies = txtDiseases.Text;
                    string[] arrayDiseasies = diseasies.Split(',');

                    // saves the diseases of the citizen in the database
                    foreach (var d in arrayDiseasies)
                    {
                        Disease newDisease = new Disease
                        {
                            DiseaseName = d,
                            DuiCitizen = dui
                        };

                        db.Diseases.Add(newDisease);
                        db.SaveChanges();
                    }
                }
                 
                 // Tiene alguna discapacidad
                 if(txtDisabilities.TextLength > 0)
                 {
                     // obtains all disabilities of the citizen
                     string disabilities = txtDisabilities.Text;
                     string[] arrayDisabilities = disabilities.Split(',');

                    // saves the disabilities of the citizen in the database
                    foreach (var d in arrayDisabilities)
                    {
                        Disability newDisability = new Disability
                        {
                            DisabilityName = d,
                            DuiCitizen = dui
                        };

                        db.Disabilities.Add(newDisability);
                        db.SaveChanges();
                    }
                 }

                MessageBox.Show("Usuario registrado con éxito", "Vacunación COVID-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Random r = new Random();
                int idVacCenter = r.Next(1, 7);

                AppointmentMaker appointmentManager = new AppointmentMaker(db);

                Appointment createdAppointment = appointmentManager.MakeAppointment( db.DoseTypes.Where(d => d.Id == 1).FirstOrDefault(), newCitizen, dashboard.LoggedEmployee, idVacCenter );

                frmAppointmentProcessDetails frmAppointmentProcessDetails = new frmAppointmentProcessDetails(createdAppointment, dashboard);
                frmAppointmentProcessDetails.Show();
                Hide();
            }
            else
            {
                if(years < 18)
                {
                    MessageBox.Show("Las citas para ciudadanos menores de 18 años aún no han " +
                    "sido habilitadas. Favor permanecer pendiente de los medios oficiales " +
                    "para saber la fecha en que puedas agendar tu cita de vacunación",
                    "Vacunación COVID-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se puede agendar una cita para el ciudadano {name} porque " +
                    $"no pertenece a ningún grupo prioritario", "Vacunación COVID-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            Close();
        }
    }
}
