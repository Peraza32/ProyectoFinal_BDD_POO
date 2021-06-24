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

namespace VaccinationSystemManager.Views
{
    public partial class frmSideEffects : Form
    {
        frmDashboard dashboard;

        private Model.VaccinationProcess vaccinationProcess = new Model.VaccinationProcess();
        private Model.VaccinationProcess ProcessDBdata = new Model.VaccinationProcess();
        private Model.PresentedSideEffect vaccinationSideEffect = new Model.PresentedSideEffect();
        private Model.Appointment anAppointment = new Model.Appointment();
        public frmSideEffects(Model.Appointment appointment, Model.VaccinationProcess process, frmDashboard dash)
        {
            InitializeComponent();
            dashboard = dash;
            anAppointment = appointment;
            vaccinationProcess = process;
        }

        private void frmSideEffects_Load(object sender, EventArgs e)
        {
            var db = new Model.G4ProyectoDBContext();

            cmbSideEffectsList.DataSource = db.SideEffects.ToList();
            cmbSideEffectsList.ValueMember = "id";
            cmbSideEffectsList.DisplayMember = "effect";
        }

        private void btnSideEffectsSave_Click(object sender, EventArgs e)
        {
            var db = new Model.G4ProyectoDBContext();

            ProcessDBdata = db.VaccinationProcesses
                .Where(u => u.DuiCitizen == vaccinationProcess.DuiCitizen)
                .Where(u => u.ShotType == vaccinationProcess.ShotType)
                .FirstOrDefault();

            // saves the side effect in database
            vaccinationSideEffect.AppearanceTime = Convert.ToInt32(nudAppearanceTime.Value);
            vaccinationSideEffect.IdVaccinationProcess = ProcessDBdata.Id;
            vaccinationSideEffect.IdSideEffect = (cmbSideEffectsList.SelectedIndex + 1);

            db.PresentedSideEffects.Add(vaccinationSideEffect);
            db.SaveChanges();
        }

        private void btnSideEffectsCancel_Click(object sender, EventArgs e)
        {
            var db = new Model.G4ProyectoDBContext();

            //Check if it's necesary to schedule a new appointment for dose 2
            if (vaccinationProcess.ShotType == 1)
            {
                MessageBox.Show("Agendando cita para la segunda dosis",
                "Vacunación COVID-19",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                AppointmentMaker appointmentManager = new AppointmentMaker(db);

                Model.Appointment currentAppointment = appointmentManager.MakeAppointment(
                                                                                            db.DoseTypes.Where(d => d.Id == 2).FirstOrDefault(),
                                                                                            db.Citizens.Where(c => c.Dui == anAppointment.DuiCitizen).FirstOrDefault(),
                                                                                            dashboard.LoggedEmployee,
                                                                                            anAppointment.IdCenter
                                                                                         );

                frmAppointmentProcessDetails details = new frmAppointmentProcessDetails(currentAppointment, dashboard);
                MessageBox.Show("Proceso de vacunación registrado correctamente",
                "Vacunación COVID-19",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                details.Show();
                this.Close();
            }
            else
            {
                // Returns to dashboard
                MessageBox.Show("Proceso de vacunación registrado correctamente * le da un dulce *",
                    "Vacunación COVID-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dashboard.Show();
                this.Close();
        
            }
        }
    }
}
