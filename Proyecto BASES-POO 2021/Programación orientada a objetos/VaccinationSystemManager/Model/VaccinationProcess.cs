using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class VaccinationProcess
    {
        public VaccinationProcess()
        {
            PresentedSideEffects = new HashSet<PresentedSideEffect>();
        }

        public int Id { get; set; }
        public DateTime VaccinationDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan VaccinationTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int ShotType { get; set; }
        public string DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual DoseType ShotTypeNavigation { get; set; }
        public virtual ICollection<PresentedSideEffect> PresentedSideEffects { get; set; }
    }
}
