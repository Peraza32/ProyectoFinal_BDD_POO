using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;

namespace VaccinationSystemManager.Controller
{
    static class Information
    {


        public static Appointment GetAppointment(string dui, DoseType dose)
        {
            G4ProyectoDBContext db = new G4ProyectoDBContext();

            Appointment appointment = db.Appointments
                                        .Where(a => a.DuiCitizen == dui && a.ShotType == dose.Id)
                                        .FirstOrDefault();

            return appointment;
        
        }


        public static int CheckExistence(string dui)
        {
            G4ProyectoDBContext db = new G4ProyectoDBContext();
            var num_appointments = db.Appointments
                                           .Where(a => a.DuiCitizen == dui)
                                           .Count();

            return num_appointments;
        }




    }
}
