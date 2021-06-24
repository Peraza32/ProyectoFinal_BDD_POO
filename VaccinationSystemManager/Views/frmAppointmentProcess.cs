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
        txtCabin dashboard;
        public frmAppointmentProcess(txtCabin lastForm)
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
            try
            {
                var db = new G4ProyectoDBContext();
                bool elegible = false;
                //handler chain
                EmailHandler emailValidator = new EmailHandler(null, txtEMail);
                PhoneNumberHandler phoneValidator = new PhoneNumberHandler(emailValidator, txtPhoneNumber);
                EmptyInputHandler emptyTextValidator = new EmptyInputHandler(phoneValidator, txtAddres);
                BirthdateAdultHandler birthdateValidator = new BirthdateAdultHandler(emptyTextValidator, dtpBirthDate);
                NameHandler nameValidator = new NameHandler(birthdateValidator, txtName);
                DuiHandler duiValidator = new DuiHandler(nameValidator, txtDui);
                //if the chain passes
                if (duiValidator.Validate())
                {
                    string addres = txtAddres.Text;
                    string phoneNumber = txtPhoneNumber.Text;

                    Citizen newCitizen = new Citizen
                    {
                        Dui = txtDui.Text,
                        CitizenName = txtName.Text,
                        CitizenAddress = addres,
                        PhoneNumber = phoneNumber
                    };

                    if (txtEMail.Text.Trim() != string.Empty)
                    {
                        newCitizen.EMail = txtEMail.Text;
                    }
                    else
                    {
                        newCitizen.EMail = null;
                    }

                    if (txtEssentialInstitution.Text.Trim() != string.Empty)
                    {
                        newCitizen.IdentifierNumber = txtEssentialInstitution.Text;
                        elegible = true;
                    }
                    else
                    {
                        newCitizen.IdentifierNumber = null;
                    }
                    // saves the new citizen in the database
                    db.Citizens.Add(newCitizen);
                    db.SaveChanges();

                    // has a chronic illness
                    if (txtDiseases.TextLength > 0)
                    {
                        elegible = true;
                        // obtains all diseases of the citizen
                        string diseasies = txtDiseases.Text;
                        string[] arrayDiseasies = diseasies.Split(',');

                        // saves the diseases of the citizen in the database
                        foreach (var d in arrayDiseasies)
                        {
                            Disease newDisease = new Disease
                            {
                                DiseaseName = d,
                                DuiCitizen = txtDui.Text
                            };

                            db.Diseases.Add(newDisease);
                            db.SaveChanges();
                        }
                    }
                    // has a dissability
                    else if (txtDisabilities.TextLength > 0)
                    {
                        elegible = true;
                        // obtains all disabilities of the citizen
                        string disabilities = txtDisabilities.Text;
                        string[] arrayDisabilities = disabilities.Split(',');

                        // saves the disabilities of the citizen in the database
                        foreach (var d in arrayDisabilities)
                        {
                            Disability newDisability = new Disability
                            {
                                DisabilityName = d,
                                DuiCitizen = txtDui.Text
                            };
                            db.Disabilities.Add(newDisability);
                            db.SaveChanges();
                        }
                    }
                    //checks if the person is elegible for vaccination
                    if (elegible)
                    {
                        Random r = new Random();
                        int idVacCenter = r.Next(1, 7);

                        AppointmentMaker appointmentManager = new AppointmentMaker(db);
                        //saves and shows the created appointment
                        Appointment createdAppointment = appointmentManager.MakeAppointment(db.DoseTypes.Where(d => d.Id == 1).FirstOrDefault(), newCitizen, dashboard.LoggedEmployee, idVacCenter);

                        frmAppointmentProcessDetails frmAppointmentProcessDetails = new frmAppointmentProcessDetails(createdAppointment, dashboard);
                        frmAppointmentProcessDetails.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show($"No se puede agendar una cita para el ciudadano {txtName.Text} porque " +
                        $"no pertenece a ningún grupo prioritario", "Vacunación COVID-19",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Removes the person from the database if its not elegible for vaccination
                        db.Citizens.Remove(newCitizen);
                        db.SaveChanges();
                    }
                }
            }
            catch(FormInputException ex)
            {
                epAppointment.SetError(ex.errorTarget, ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            Close();
        }

        private void txtEssentialInstitution_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Leave(object sender, EventArgs e)
        {
            epAppointment.Clear();
        }
    }
}
