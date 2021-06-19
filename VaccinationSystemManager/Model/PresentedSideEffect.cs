using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class PresentedSideEffect
    {
        public int IdVaccinationProcess { get; set; }
        public int IdSideEffect { get; set; }

        public virtual SideEffect IdSideEffectNavigation { get; set; }
        public virtual VaccinationProcess IdVaccinationProcessNavigation { get; set; }
    }
}
