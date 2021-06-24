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
using VaccinationSystemManager.Model;


namespace VaccinationSystemManager.Views
{
    public partial class txtCabin : Form
    {
        public Cabin LoggedCabin { get; }
        public Employee LoggedEmployee { get; }
        public txtCabin(Employee currentEmployee, Cabin currentCabin)
        {
            LoggedCabin = currentCabin;
            LoggedEmployee = currentEmployee;
            InitializeComponent();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointmentProcess appointmentClient = new frmAppointmentProcess(this);
            appointmentClient.Show();
            Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblCurrenEmployee.Text = $"{LoggedEmployee.EmployeeName}";
            lblCabin.Text = $"{LoggedCabin.CabinAddress}";
        }

        private void btnVacProcess_Click(object sender, EventArgs e)
        {
            frmVerifyCitizen frmVerify = new frmVerifyCitizen(this);
            frmVerify.Show();
            Hide();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
