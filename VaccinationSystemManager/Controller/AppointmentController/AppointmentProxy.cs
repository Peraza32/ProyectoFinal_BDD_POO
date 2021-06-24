using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;

namespace VaccinationSystemManager.Controller.AppointmentController
{
    class AppointmentProxy : IAppointment
    {

        
        private AppointmentMaker appointment;

        public AppointmentProxy(G4ProyectoDBContext db)
        {
            appointment = new AppointmentMaker(db);
        }

        public Model.Appointment MakeAppointment(DoseType shotType, Citizen person, Employee manager, int idVaccinationCenter, DateTime date)
        {
           return appointment.MakeAppointment(shotType, person, manager, idVaccinationCenter,  date);
        }

       


        public DateTime GenerateDate(VaccinationCenter location, DoseType type)
        {
            //bucle control variable
           
            DateTime appointmentDate;

            if (type.Id == 1)
            {
                appointmentDate = DateTime.Now.Date.AddDays(1).AddHours(8);
            }
            else
            {
                appointmentDate = DateTime.Now.Date.AddDays(42).AddHours(8);
            }

            Model.Appointment newAppointment = new Model.Appointment();
            

            appointmentDate = appointment.GetAvailability(appointmentDate, location);

            return appointmentDate;
        }
    }
}
