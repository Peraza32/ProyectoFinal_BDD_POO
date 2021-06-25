using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccinationSystemManager.Model;

namespace VaccinationSystemManager.Controller.AppointmentController
{
    interface IPDFCreator
    {
        public void SavePDF(Citizen patient, Appointment appointment);
    }
}
