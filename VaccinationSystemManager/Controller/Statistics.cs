using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationSystemManager.Controller
{
    public static class Statistics
    {
        //Count Vaccination Process
        public static int CountVaccinationProcess(int countShotType)
        {
            int count;

            using (Model.G4ProyectoDBContext db = new Model.G4ProyectoDBContext())
            {
                count = db.VaccinationProcesses
                    .Where(u => u.ShotType == countShotType)
                    .Count();
            }

            return count;
        }
    }
}
