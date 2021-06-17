using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class TipoEmpleado
    {
        public TipoEmpleado()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
