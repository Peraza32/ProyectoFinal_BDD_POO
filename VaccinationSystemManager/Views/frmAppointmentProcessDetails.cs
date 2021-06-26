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
        }
    }
}
