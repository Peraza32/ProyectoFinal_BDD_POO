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
    }
}
