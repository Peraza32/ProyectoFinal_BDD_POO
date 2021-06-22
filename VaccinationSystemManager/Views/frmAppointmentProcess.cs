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

namespace VaccinationSystemManager.Views
{
    public partial class frmAppointmentProcess : Form
    {
        public frmAppointmentProcess()
        {
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
            var db = new Model.G4ProyectoDBContext();

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

            // ASIGNAMOS UN CENTRO DE VACUNACIÓN AL USUARIO

            // generamos un número aleatorio entre 1 y 6
            Random r = new Random();
            int idVaccinationCenter = r.Next(1, 7);

            // buscamos el centro de vacunación en la base de datos usando
            // el número aleatorio generado como id del centro de vacunación
            VaccinationCenter vaccinationCenterBDD = db.Set<VaccinationCenter>()
                .SingleOrDefault(vc => vc.Id == idVaccinationCenter);

            // ASIGNAMOS UNA FECHA Y HORA DE VACUNACIÓN AL USUARIO

            // variable que nos permite controlar el bucle
            bool next = true;
            // acumuladores que nos permiten asignar una fecha y hora de vacunación
            int days = 1;
            int hours = 8;
            DateTime appointmentDate;
            Appointment newAppointment = new Appointment();

            while (next)
            {
                // tomamos como fecha base la fecha actual
                DateTime baseDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, .000);
                // a la fecha base le vamos sumando 1 hora o 1 día según se vaya agotando la disponibilidad
                // de cupos en el centro de vacunación asignado
                appointmentDate = baseDate.AddDays(days).AddHours(hours).AddMinutes(0).AddSeconds(0).AddMilliseconds(.000);

                // recuperamos una lista de las reservas realizadas en la hora y centro de vacunación
                // generado para el ciudadano
                var totalAppointments = db.Appointments
                    .Where(ap => ap.AppointmentDate == appointmentDate && ap.IdCenter == idVaccinationCenter)
                    .ToList();

                // comparamos que existan cupos disponibles
                if ( (vaccinationCenterBDD.Capacity - totalAppointments.Count) > 0)
                {
                    // saves the new appointment in the database
                    newAppointment.AppointmentDate = appointmentDate;
                    newAppointment.ShotType = 1;
                    newAppointment.IdCenter = idVaccinationCenter;
                    newAppointment.DuiCitizen = txtDui.Text;
                    newAppointment.IdEmployee = 1; // cambiar por el id real del empleado cuando se implemente con el login

                    db.Appointments.Add(newAppointment);
                    db.SaveChanges();

                    MessageBox.Show($"Cita agendada con éxito!", "Vacunación COVID-19", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // gets out of the loop
                    next = false;
                }
                else
                {
                    // si no hay cupos, sumamos horas a la fecha generada
                    if (hours < 17)
                        hours++;
                    else // si ya no hay cupos para antes de las 5 de la tarde, sumamos 1 día
                    {
                        hours = 8;
                        days++;
                    }
                }
            }

            // shows "Appointment Details" form 
            frmAppointmentProcessDetails frmAppointmentProcessDetails = new frmAppointmentProcessDetails(dui, 
                name, newAppointment.AppointmentDate, vaccinationCenterBDD.CenterName, this);
            frmAppointmentProcessDetails.Show();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
