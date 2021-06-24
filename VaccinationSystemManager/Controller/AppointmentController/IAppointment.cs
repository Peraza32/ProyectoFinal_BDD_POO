using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;


namespace VaccinationSystemManager.Controller.AppointmentController
{
    interface IAppointment
    {
        public Model.Appointment MakeAppointment(DoseType shotType, Citizen person, Employee manager, int idVaccinationCenter, DateTime date);
    }
}
