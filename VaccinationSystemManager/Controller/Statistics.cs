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

        //Retrieving side effects name
        public static List<Model.SideEffect> RetrieveSideEffectName()
        {
            List<Model.SideEffect> effects = new List<Model.SideEffect>();

            using (Model.G4ProyectoDBContext db = new Model.G4ProyectoDBContext())
            {
                effects = db.SideEffects
                    .ToList();

                return effects;
            }

            
        }

        //Count Presented Side Effects
        public static int CountPresentedSideEffect(int idSideEffect)
        {
            int count;

            using (Model.G4ProyectoDBContext db = new Model.G4ProyectoDBContext())
            {
                count = db.PresentedSideEffects
                    .Where(u => u.IdSideEffect == idSideEffect)
                    .Count();
            }

            return count;
        }

        //Count Efficiency
        public static int CountEfficiency(int range)
        {
            int count = 0;
            List<Model.VaccinationProcess> vaccinationProcess = new List<Model.VaccinationProcess>();

            using (Model.G4ProyectoDBContext db = new Model.G4ProyectoDBContext())
            {
                vaccinationProcess = db.VaccinationProcesses
                        .ToList();
            }

            TimeSpan totalSpan;

            foreach(Model.VaccinationProcess data in vaccinationProcess)
            {
                totalSpan = (data.EndTime - data.StartTime);

                //[30 a 45)
                if ((range == 1) && ((totalSpan.TotalMinutes >= 30) && (totalSpan.TotalMinutes < 45)))
                {
                    ++count;
                }
                //[45 a hora)
                else if ((range == 2) && ((totalSpan.TotalMinutes >= 45) && (totalSpan.TotalMinutes < 60)))
                {
                    ++count;
                }
                //[hora a +inf)
                else if ((range == 3) && (totalSpan.TotalMinutes >= 60))
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
