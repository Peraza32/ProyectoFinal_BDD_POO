using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int ShotType { get; set; }
        public int IdCenter { get; set; }
        public string DuiCitizen { get; set; }
        public int IdEmployee { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual VaccinationCenter IdCenterNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual DoseType ShotTypeNavigation { get; set; }
    }
}
