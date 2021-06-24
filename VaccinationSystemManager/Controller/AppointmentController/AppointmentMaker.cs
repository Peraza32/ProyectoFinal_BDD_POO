using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;
using System.Windows.Forms;

namespace VaccinationSystemManager.Controller.AppointmentController
{
    class AppointmentMaker
    {
        G4ProyectoDBContext database;

        public AppointmentMaker(G4ProyectoDBContext db)
        {
            database = db;
        }

        private DateTime GenerateDate(VaccinationCenter location, DoseType type)
        {
            //bucle control variable
            bool next = true;
            DateTime appointmentDate;

            if(type.Id == 1)
            {
                appointmentDate = DateTime.Now.Date.AddDays(1).AddHours(8);
            }
            else
            {
                appointmentDate = DateTime.Now.Date.AddDays(42).AddHours(8);
            }

            Model.Appointment newAppointment = new Model.Appointment();

            while (next)
            {
                // getting all appointments in an specific center
                var totalAppointments = database.Appointments
                    .Where(ap => ap.AppointmentDate == appointmentDate && ap.IdCenter == location.Id)
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
                    if (appointmentDate.Hour < 17)
                        appointmentDate.AddHours(1);
                    else // when it reaches the end of the day adds another day and resets the date
                    {
                        appointmentDate.AddDays(1);
                        appointmentDate = appointmentDate.Date.AddHours(8);
                    }
                }
            }

            return appointmentDate;
        }

        public Model.Appointment MakeAppointment(DoseType shotType, Citizen person, Employee manager, int idVaccinationCenter)
        {
            // searching with the random index in the database
            VaccinationCenter vaccinationCenterBDD = database.Set<VaccinationCenter>()
                .SingleOrDefault(vc => vc.Id == idVaccinationCenter);

            //creating the new appointment with the given data and a valid date
            Model.Appointment newAppointment = new Model.Appointment
            {
                AppointmentDate = GenerateDate(vaccinationCenterBDD, shotType),
                ShotType = shotType.Id,
                IdCenter = idVaccinationCenter,
                DuiCitizen = person.Dui,
                IdEmployee = manager.Id
            };

            database.Appointments.Add(newAppointment);

            database.SaveChanges();

            if(newAppointment.ShotType == 1)
            {
                MessageBox.Show($"Cita agendada con éxito!", "Vacunación COVID-19", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Cita para la segunda dosis agendada con éxito!", "Vacunación COVID-19", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
               
            return newAppointment;
        }

    }
}
