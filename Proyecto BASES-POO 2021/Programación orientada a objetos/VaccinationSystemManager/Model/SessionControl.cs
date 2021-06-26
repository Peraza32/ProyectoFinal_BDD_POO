using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class SessionControl
    {
        public int Id { get; set; }
        public DateTime SessionDate { get; set; }
        public int IdEmployee { get; set; }
        public int IdCabin { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
