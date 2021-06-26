using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class VaccinationCenter
    {
        public VaccinationCenter()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string CenterAddress { get; set; }
        public string CenterName { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
