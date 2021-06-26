using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;

namespace VaccinationSystemManager.Controller
{
    static class UserInformation
    {


        public static Appointment GetAppointment(string dui, DoseType dose)
        {
            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {
                Appointment appointment = db.Appointments
                                           .Where(a => a.DuiCitizen == dui && a.ShotType == dose.Id)
                                           .FirstOrDefault();

                return appointment;
            }
           

            
        
        }

        public static Appointment GetAppointment(string dui, int dose)
        {
            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {
                Appointment appointment = db.Appointments
                                           .Where(a => a.DuiCitizen == dui && a.ShotType == dose)
                                           .FirstOrDefault();

                return appointment;
            }




        }

        public static Appointment GetAppointment(string dui, DateTime date)
        {
            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {
                Appointment appointment = db.Appointments
                                           .Where(a => a.DuiCitizen == dui && a.AppointmentDate == date)
                                           .FirstOrDefault();

                return appointment;
            }




        }


        public static int CheckExistence(string dui)
        {
            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {
                var num_appointments = db.Appointments
                                             .Where(a => a.DuiCitizen == dui)
                                             .Count();

                return num_appointments;
            }
            
        }


        public static VaccinationCenter GetVaccinationCenter(int idCenter)
        {
            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {
                var vCenter = db.VaccinationCenters
                              .Where(v => v.Id == idCenter)
                              .SingleOrDefault();


                return vCenter;
            }
            
        }

        public static DoseType GetDoseType(int idDose)
        {
            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {
                var Dose = db.DoseTypes.Where(d => d.Id == idDose)
                            .FirstOrDefault();


                return Dose;
            }
            
        }


        public static Citizen GetCitizen(string id)
        {
            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {
                var citizen = db.Citizens
                  .Where(c => c.Dui == id)
                  .FirstOrDefault();

                return citizen;
            }
            
        
        }

        public static int CountVaccination(string dui, int dose)
        {
            

            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {
                var countVaccine = db.VaccinationProcesses
                            .Where(u => u.DuiCitizen == dui)
                            .Where(u => u.ShotType == dose)
                            .Count();


                return countVaccine;
            }
        }

    }
}
