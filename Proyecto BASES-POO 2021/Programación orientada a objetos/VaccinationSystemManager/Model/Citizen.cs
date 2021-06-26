using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
            Disabilities = new HashSet<Disability>();
            Diseases = new HashSet<Disease>();
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }

        public string Dui { get; set; }
        public string CitizenName { get; set; }
        public string IdentifierNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string CitizenAddress { get; set; }
        public string EMail { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Disability> Disabilities { get; set; }
        public virtual ICollection<Disease> Diseases { get; set; }
        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
