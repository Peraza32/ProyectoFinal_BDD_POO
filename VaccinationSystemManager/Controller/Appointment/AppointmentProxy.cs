using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;

namespace VaccinationSystemManager.Controller
{
    class AppointmentProxy:IAppointment
    {

        private G4ProyectoDBContext database;

        public bool MakeAppointment(DoseType dose)
        {
            return true;
        }
    }
}
