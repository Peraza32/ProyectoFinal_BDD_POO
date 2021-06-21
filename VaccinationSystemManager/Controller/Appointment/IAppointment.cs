using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;

namespace VaccinationSystemManager.Controller
{
    interface IAppointment
    {
        public bool MakeAppointment(DoseType dose);
    }
}
