using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationSystemManager.Controller.Appointment
{
    interface IPDFCreator
    {
        public bool SavePDF();
    }
}
