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
    public partial class Dashboard : Form
    {
        Employee loggedEmployee;
        public Dashboard(Employee currentEmployee)
        {
            loggedEmployee = currentEmployee;
            InitializeComponent();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointmentProcess appointmentClient = new frmAppointmentProcess(loggedEmployee, this);
            appointmentClient.Show();
            Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblCurrenEmployee.Text = loggedEmployee.EmployeeName;
        }
    }
}
