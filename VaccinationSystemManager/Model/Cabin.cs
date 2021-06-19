using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class Cabin
    {
        public Cabin()
        {
            InCharges = new HashSet<InCharge>();
            SessionControls = new HashSet<SessionControl>();
        }

        public int Id { get; set; }
        public string CabinAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }

        public virtual ICollection<InCharge> InCharges { get; set; }
        public virtual ICollection<SessionControl> SessionControls { get; set; }
    }
}
