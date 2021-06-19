using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            PresentedSideEffects = new HashSet<PresentedSideEffect>();
        }

        public int Id { get; set; }
        public string Effect { get; set; }

        public virtual ICollection<PresentedSideEffect> PresentedSideEffects { get; set; }
    }
}
