using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class Sesion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCabina { get; set; }

        public virtual Cabina IdCabinaNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
