using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class Citum
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoDosis { get; set; }
        public int IdCentro { get; set; }
        public string DuiCiudadano { get; set; }
        public int IdEmpleado { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual CentroVacunacion IdCentroNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual TipoDosi TipoDosisNavigation { get; set; }
    }
}
