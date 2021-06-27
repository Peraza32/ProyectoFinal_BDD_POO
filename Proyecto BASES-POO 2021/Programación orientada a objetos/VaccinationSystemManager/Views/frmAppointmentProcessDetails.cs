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
    public partial class frmAppointmentProcessDetails : Form
    {
        frmDashboard dashboard;
        string dui;
        string name;
        string date;
        string hour;
        string vaccinationCenterName;
        Citizen citizen;
        VaccinationCenter vaccinationCenter;
        DoseType doseType;
        Appointment actualAppointment;

        public frmAppointmentProcessDetails(Appointment anAppointment, frmDashboard dash)
        {
            InitializeComponent();
            

            dashboard = dash;

            // recovers the citizen from BDD
            citizen = UserInformation.GetCitizen(anAppointment.DuiCitizen);
            

            // recovers the vaccination center from BDD
            vaccinationCenter = UserInformation.GetVaccinationCenter(anAppointment.IdCenter);


            // recovers the dose type from BDD
            doseType = UserInformation.GetDoseType(anAppointment.ShotType);


            dui = anAppointment.DuiCitizen;
            name = citizen.CitizenName;
            date = anAppointment.AppointmentDate.ToString("dd-MM-yyyy");
            hour = anAppointment.AppointmentDate.ToString("hh:mm tt");
            vaccinationCenterName = vaccinationCenter.CenterName;
            actualAppointment = anAppointment;
        }

        private void frmAppointmentProcessDetails_Load(object sender, EventArgs e)
        {
            lblDui.Text = dui;
            lblCitizenName.Text = name;
            lblDate.Text = date;
            lblHour.Text = hour;

            if (doseType.Id == 1)
                lblDoseType.Text = "Primera Dosis";
            else
                lblDoseType.Text = "Segunda Dosis";

            lblVaccinationCenter.Text = vaccinationCenterName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            G4ProyectoDBContext db = new G4ProyectoDBContext();
            AppointmentProxy appointment = new AppointmentProxy(db);
            appointment.SavePDF(citizen,actualAppointment);
            MessageBox.Show("PDF generado con éxito! Puedes encontrarlo en la carpeta \"Documentos\" con " +
                              "el nombre y dui del paciente",
                              "Vacunación COVID-19",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            dashboard.Show();
            Close();
        }

        private void btnStartVaccinationProcess_Click(object sender, EventArgs e)
        {
            var db = new Model.G4ProyectoDBContext();

            var countUser = UserInformation.CheckExistence(dui);

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

                    var currentAppointment = checkAppointment;

                    //Delete previus appointment in order to avoid future confilcs
                    db.Remove(db.Appointments.SingleOrDefault(u => u.Id == checkAppointment.Id));
                    db.SaveChanges();

                    // delete citizen's diseasies from database
                    var citizenDiseasies = db.Diseases
                        .Where(d => d.DuiCitizen == currentAppointment.DuiCitizen)
                        .ToList();

                    if (citizenDiseasies.Count > 0)
                    {
                        foreach (var d in citizenDiseasies)
                        {
                            db.Remove(d);
                            db.SaveChanges();
                        }
                    }

                    // delete citizen's disabilities from database
                    var citizenDisabilities = db.Disabilities
                        .Where(d => d.DuiCitizen == currentAppointment.DuiCitizen)
                        .ToList();

                    if (citizenDisabilities.Count > 0)
                    {
                        foreach (var d in citizenDisabilities)
                        {
                            db.Remove(d);
                            db.SaveChanges();
                        }
                    }

                    // delete citizen from database
                    db.Remove(db.Citizens.SingleOrDefault(c => c.Dui == currentAppointment.DuiCitizen));
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
    }
}
