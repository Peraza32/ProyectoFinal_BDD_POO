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
    public partial class frmSideEffects : Form
    {
        private Model.VaccinationProcess vaccinationProcess = new Model.VaccinationProcess();
        private Model.VaccinationProcess ProcessDBdata = new Model.VaccinationProcess();
        private Model.PresentedSideEffect vaccinationSideEffect = new Model.PresentedSideEffect();
        public frmSideEffects(Model.VaccinationProcess process)
        {
            InitializeComponent();

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

            vaccinationSideEffect.IdVaccinationProcess = ProcessDBdata.Id;
            vaccinationSideEffect.IdSideEffect = (cmbSideEffectsList.SelectedIndex + 1);

            db.PresentedSideEffects.Add(vaccinationSideEffect);
            db.SaveChanges();

            MessageBox.Show("Proceso de vacunación registrado correctamente",
                            "Vacunación COVID-19",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            //Devolver al Dashboard
        }

        private void btnSideEffectsCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proceso de vacunación registrado correctamente",
                            "Vacunación COVID-19",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

            //Devolver al Dashboard
        }
    }
}
