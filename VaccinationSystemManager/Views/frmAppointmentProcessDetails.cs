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
    public partial class frmAppointmentProcessDetails : Form
    {
        frmAppointmentProcess refAppointmentProcess = null;
        string dui;
        string name;
        string date;
        string hour;
        string vaccinationCenter;

        public frmAppointmentProcessDetails(string citizenDui, string citizenName, DateTime appointmentDate, 
            string nameVaccinationCenter, frmAppointmentProcess frmAppointmentProcess)
        {
            InitializeComponent();
            refAppointmentProcess = frmAppointmentProcess;
            dui = citizenDui;
            name = citizenName;
            date = appointmentDate.ToString("dd-MM-yyyy");
            hour = appointmentDate.ToString("hh:mm tt");
            vaccinationCenter = nameVaccinationCenter;
        }

        private void frmAppointmentProcessDetails_Load(object sender, EventArgs e)
        {
            lblDui.Text = dui;
            lblCitizenName.Text = name;
            lblDate.Text = date;
            lblHour.Text = hour;
            lblVaccinationCenter.Text = vaccinationCenter;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

            // programar que se muestre el dashboard
        }
    }
}
