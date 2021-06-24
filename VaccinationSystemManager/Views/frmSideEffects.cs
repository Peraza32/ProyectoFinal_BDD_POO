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
        txtCabin dashboard;

        private Model.VaccinationProcess vaccinationProcess = new Model.VaccinationProcess();
        private Model.Appointment anAppointment = new Model.Appointment();
        public frmSideEffects(Model.Appointment appointment, Model.VaccinationProcess process, txtCabin dash)
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

            Model.VaccinationProcess vaccinationProcessBDD = new Model.VaccinationProcess();

            var db = new Model.G4ProyectoDBContext();

            vaccinationProcessBDD = db.VaccinationProcesses.
                Where(u => u.DuiCitizen == vaccinationProcess.DuiCitizen &&
                           u.ShotType == vaccinationProcess.ShotType)
                .FirstOrDefault();

            Model.PresentedSideEffect presentedSideEffect = new Model.PresentedSideEffect
            {
                AppearanceTime = Convert.ToInt32(nudAppearanceTime.Value),
                IdVaccinationProcess = vaccinationProcessBDD.Id,
                IdSideEffect = cmbSideEffectsList.SelectedIndex + 1
            };

            db.PresentedSideEffects.Add(presentedSideEffect);
            db.SaveChanges();

              MessageBox.Show("Efecto secundario registrado con éxito",
                              "Vacunación COVID-19",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var db = new Model.G4ProyectoDBContext();

            //Check if it's necesary to schedule a new appointment for dose 2
            if (vaccinationProcess.ShotType == 1)
            {
                AppointmentMaker appointmentManager = new AppointmentMaker(db);

                Model.Appointment currentAppointment = appointmentManager.MakeAppointment(
                                                                                            db.DoseTypes.Where(d => d.Id == 2).FirstOrDefault(),
                                                                                            db.Citizens.Where(c => c.Dui == anAppointment.DuiCitizen).FirstOrDefault(),
                                                                                            dashboard.LoggedEmployee,
                                                                                            anAppointment.IdCenter
                                                                                         );

                frmAppointmentProcessDetails details = new frmAppointmentProcessDetails(currentAppointment, dashboard);

                details.Show();
                Close();
            }
            else
            {
                // Returns to dashboard
                MessageBox.Show("Proceso de vacunación registrado correctamente * le da un dulce *",
                    "Vacunación COVID-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dashboard.Show();
                Close();

            }
        }
    }
}
