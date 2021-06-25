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

        private void dtgAppointments_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridObject data = new DataGridObject();

                try
                {
                    data = dtgAppointments.SelectedRows[e.RowIndex].DataBoundItem as DataGridObject;

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

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            dashboard.Show();
            this.Close();
        }
    }
}
