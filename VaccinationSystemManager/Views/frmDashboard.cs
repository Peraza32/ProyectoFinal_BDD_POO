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
    public partial class frmDashboard : Form
    {
        public Employee LoggedEmployee { get; }
        public frmDashboard(Employee currentEmployee)
        {
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
            lblCurrenEmployee.Text = LoggedEmployee.EmployeeName;
        }

        private void btnVacProcess_Click(object sender, EventArgs e)
        {
            frmVerifyCitizen frmVerify = new frmVerifyCitizen(this);
            frmVerify.Show();
            Hide();
        }
    }
}
