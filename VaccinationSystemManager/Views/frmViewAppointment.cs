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
    public partial class frmViewAppointment : Form
    {
        frmDashboard dashboard;
        DataGridObject dataObject = new DataGridObject();
        public frmViewAppointment(frmDashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
        }

        private void btnBeginProcess_Click(object sender, EventArgs e)
        {
            
            
            if (txtDui.Text != string.Empty)
            {
                frmStartVaccinationProcess vaccinationProcess = new frmStartVaccinationProcess(UserInformation.GetCitizen(txtDui.Text), UserInformation.GetAppointment(txtDui.Text, dtpFecha.Value), dashboard);
                this.Hide();
                vaccinationProcess.Show();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
      
                
            if (cboTimeFrame.SelectedIndex == 0)
            {
                PopulateDataGrid(AppointmentInformation.GetAppointmentsOfTheDay(DateTime.Now));
            }
            else if (cboTimeFrame.SelectedIndex == 1)
            {
                PopulateDataGrid(AppointmentInformation.GetAppointmentsWeekly(DateTime.Now));
            }
            else if (cboTimeFrame.SelectedIndex == 2)
            {
                PopulateDataGrid(AppointmentInformation.GetAppointmentsMonthly(DateTime.Now));
            }
            else if (cboTimeFrame.SelectedIndex == 3)
            {
                PopulateDataGrid(AppointmentInformation.GetAppointments());
            }
            else
                MessageBox.Show("Por favor seleccione una opcion", "Opcion de consulta vacia", MessageBoxButtons.OK);
        }

        private void dtgAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridObject data = new DataGridObject();

                try
                {
                    data = dtgAppointments.SelectedRows[0].DataBoundItem as DataGridObject;

                    txtDui.Text = data.Dui;
                    txtPaciente.Text = data.Name;
                    txtDosis.Text = data.Dose;
                    dtpFecha.Value = data.Date;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            else
                MessageBox.Show(e.RowIndex.ToString());
        }

        private void frmViewAppointment_Load(object sender, EventArgs e)
        {
            cboTimeFrame.Items.Add("Dia");
            cboTimeFrame.Items.Add("Semana");
            cboTimeFrame.Items.Add("Mes");
            cboTimeFrame.Items.Add("Todas");
            cboTimeFrame.SelectedIndex = 0;
        }

        private void PopulateDataGrid(List<DataGridObject> info)
        {
            
            
            BindingList<DataGridObject> source = new BindingList<DataGridObject>(info);
            dtgAppointments.DataSource = null;
            dtgAppointments.DataSource = source;
            
            dtgAppointments.RowTemplate.ReadOnly = true;
            dtgAppointments.ForeColor = Color.Black;

        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {

            dashboard.Show();
            this.Close();
        }

        private void btnBeginProcess_Click_1(object sender, EventArgs e)
        {
            try
            {
                DuiHandler duiValidator = new DuiHandler(null, txtDui);

                duiValidator.Validate();

                string dui = txtDui.Text;

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
            catch (FormInputException ex)
            {
                epVerify.SetError(ex.errorTarget, ex.Message);
            }
        }
    }
}
