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

        private G4ProyectoDBContext database;

        public Model.Appointment MakeAppointment(DoseType shotType, Citizen person, Employee manager)
        {
            return new Appointment();
        }
    }
}
