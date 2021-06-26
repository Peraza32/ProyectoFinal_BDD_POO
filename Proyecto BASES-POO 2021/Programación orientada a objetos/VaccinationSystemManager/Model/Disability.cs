using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class Disability
    {
        public int Id { get; set; }
        public string DisabilityName { get; set; }
        public string DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
    }
}
