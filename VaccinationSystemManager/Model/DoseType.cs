using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class DoseType
    {
        public DoseType()
        {
            Appointments = new HashSet<Appointment>();
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }

        public int Id { get; set; }
        public string ShotType { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
