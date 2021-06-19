using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class Employee
    {
        public Employee()
        {
            Appointments = new HashSet<Appointment>();
            InCharges = new HashSet<InCharge>();
            SessionControls = new HashSet<SessionControl>();
        }

        public int Id { get; set; }
        public string EmployeeUser { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EMail { get; set; }
        public int IdType { get; set; }

        public virtual EmployeeType IdTypeNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<InCharge> InCharges { get; set; }
        public virtual ICollection<SessionControl> SessionControls { get; set; }
    }
}
