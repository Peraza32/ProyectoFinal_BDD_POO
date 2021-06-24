using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;
using System.Windows.Forms;

namespace VaccinationSystemManager.Controller.AppointmentController
{
     class AppointmentMaker:IAppointment
    {
        G4ProyectoDBContext database;

        public AppointmentMaker(G4ProyectoDBContext db)
        {
            database = db;
        }

        public Model.Appointment MakeAppointment(DoseType shotType, Citizen person, Employee manager, int idVaccinationCenter, DateTime date)
        {
            // searching with the random index in the database
            VaccinationCenter vaccinationCenterBDD = database.Set<VaccinationCenter>()
                .SingleOrDefault(vc => vc.Id == idVaccinationCenter);

            //creating the new appointment with the given data and a valid date
            Model.Appointment newAppointment = new Model.Appointment
            {
                AppointmentDate = date,
                ShotType = shotType.Id,
                IdCenter = idVaccinationCenter,
                DuiCitizen = person.Dui,
                IdEmployee = manager.Id
            };

            database.Appointments.Add(newAppointment);

            database.SaveChanges();

            MessageBox.Show($"Cita agendada con éxito!", "Vacunación COVID-19", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return newAppointment;
        }


        public DateTime GetAvailability(DateTime possibleDate, VaccinationCenter location)
        {
            //Bucle control
            bool next = true;
            

            while (next)
            {
                // getting all appointments in an specific center
                var totalAppointments = database.Appointments
                    .Where(ap => ap.AppointmentDate == possibleDate && ap.IdCenter == location.Id)
                    .ToList();

                // checking if the capacity is not exceeded
                if ((location.Capacity - totalAppointments.Count) > 0)
                {
                    //if there is enough room for another apointment just exists the loop
                    next = false;
                }
                else
                {
                    //otherwise it keeps adding hours until 17:00
                    if (possibleDate.Hour < 17)
                        possibleDate.AddHours(1);
                    else // when it reaches the end of the day adds another day and resets the date
                    {
                        possibleDate.AddDays(1);
                        possibleDate = possibleDate.Date.AddHours(8);
                    }
                }
            }


            return possibleDate;
        }

        
    }
}
