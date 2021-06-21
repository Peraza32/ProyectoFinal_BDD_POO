using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;

namespace VaccinationSystemManager.Controller.Appointment
{
    class AppointmentMaker:IAppointment
    {
        public bool MakeAppointment(DoseType dose)
        {

            return true;
        
        }


        private DateTime GenerateDate()
        {

            return;
        }


    }
}
