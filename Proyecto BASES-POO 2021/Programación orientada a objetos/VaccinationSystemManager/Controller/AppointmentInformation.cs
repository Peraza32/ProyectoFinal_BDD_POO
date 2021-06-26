using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;
using Microsoft.EntityFrameworkCore;


namespace VaccinationSystemManager.Controller
{
    public static class AppointmentInformation
    {


        public static List<DataGridObject> GetAppointments()
        {
            //Getting all the appointments in the database
            List<DataGridObject> appointments = new List<DataGridObject>();

            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {//POPULATED THE LIST WITH THE INFORMATION REQUIRED BY THE DGV
                appointments = db.Citizens.Join(db.Appointments,
                                                    citizen => citizen.Dui,
                                                    appoint => appoint.DuiCitizen,
                                                    (citizen, appoint) => new DataGridObject{

                                                        Dui = citizen.Dui,
                                                        Name = citizen.CitizenName,
                                                        Date = appoint.AppointmentDate,
                                                        Dose = UserInformation.GetDoseType(appoint.ShotType).ShotType
                                                        }

                                                    ).ToList();

                return appointments;

            } 
        }
                
                                               
                                                


            
        
        



        public static List<DataGridObject> GetAppointmentsOfTheDay(DateTime today)
        {

            // Getting all the appointments in the database
            List<DataGridObject> appointments = new List<DataGridObject>();

            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {//POPULATED THE LIST WITH THE INFORMATION REQUIRED BY THE DGV
                appointments = db.Citizens.Join(db.Appointments,
                                                    citizen => citizen.Dui,
                                                    appoint => appoint.DuiCitizen,
                                                    (citizen, appoint) => new DataGridObject
                                                    {

                                                        Dui = citizen.Dui,
                                                        Name = citizen.CitizenName,
                                                        Date = appoint.AppointmentDate,
                                                        Dose = UserInformation.GetDoseType(appoint.ShotType).ShotType
                                                    }

                                                    )
                                                    .Where( o => o.Date == today)
                                                    .ToList();

                return appointments;

            }

        }


        public static List<DataGridObject> GetAppointmentsWeekly(DateTime beginDay)
        {

            // Getting all the appointments in the database
            List<DataGridObject> appointments = new List<DataGridObject>();

            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {//POPULATED THE LIST WITH THE INFORMATION REQUIRED BY THE DGV
                appointments = db.Citizens.Join(db.Appointments,
                                                    citizen => citizen.Dui,
                                                    appoint => appoint.DuiCitizen,
                                                    (citizen, appoint) => new DataGridObject
                                                    {

                                                        Dui = citizen.Dui,
                                                        Name = citizen.CitizenName,
                                                        Date = appoint.AppointmentDate,
                                                        Dose = UserInformation.GetDoseType(appoint.ShotType).ShotType
                                                    }

                                                    )
                                                    .Where(o => o.Date >= beginDay && o.Date <= beginDay.AddDays(7))
                                                    .ToList();

                return appointments;

            }

        }

        public static List<DataGridObject> GetAppointmentsMonthly(DateTime beginDay)
        {
            // Getting all the appointments in the database
            List<DataGridObject> appointments = new List<DataGridObject>();

            using (G4ProyectoDBContext db = new G4ProyectoDBContext())
            {//POPULATED THE LIST WITH THE INFORMATION REQUIRED BY THE DGV
                appointments = db.Citizens.Join(db.Appointments,
                                                    citizen => citizen.Dui,
                                                    appoint => appoint.DuiCitizen,
                                                    (citizen, appoint) => new DataGridObject
                                                    {

                                                        Dui = citizen.Dui,
                                                        Name = citizen.CitizenName,
                                                        Date = appoint.AppointmentDate,
                                                        Dose = UserInformation.GetDoseType(appoint.ShotType).ShotType
                                                    }

                                                    )
                                                    .Where(o => o.Date >= beginDay && o.Date <= beginDay.AddDays(30))
                                                    .ToList();

                return appointments;

            }

        }



    }
}
