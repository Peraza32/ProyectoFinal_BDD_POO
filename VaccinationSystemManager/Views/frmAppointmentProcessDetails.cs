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

namespace VaccinationSystemManager.Views
{
    public partial class frmAppointmentProcessDetails : Form
    {
        txtCabin dashboard;
        string dui;
        string name;
        string date;
        string hour;
        string vaccinationCenterName;
        Citizen citizen;
        VaccinationCenter vaccinationCenter;
        DoseType doseType;

        public frmAppointmentProcessDetails(Appointment anAppointment, txtCabin dash)
        {
            InitializeComponent();
            var db = new G4ProyectoDBContext();

            dashboard = dash;

            // recovers the citizen from BDD
            citizen = db.Citizens.SingleOrDefault(c => c.Dui == anAppointment.DuiCitizen);

            // recovers the vaccination center from BDD
            vaccinationCenter = db.VaccinationCenters.SingleOrDefault(vc => vc.Id == anAppointment.IdCenter);

            // recovers the dose type from BDD
            doseType = db.DoseTypes.SingleOrDefault(dt => dt.Id == anAppointment.ShotType);

            dui = anAppointment.DuiCitizen;
            name = citizen.CitizenName;
            date = anAppointment.AppointmentDate.ToString("dd-MM-yyyy");
            hour = anAppointment.AppointmentDate.ToString("hh:mm tt");
            vaccinationCenterName = vaccinationCenter.CenterName;
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
    }
}
