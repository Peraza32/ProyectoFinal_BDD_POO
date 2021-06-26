using System;
using System.Collections.Generic;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string EmployeeType1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
