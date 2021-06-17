using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class Enfermedad
    {
        public int Id { get; set; }
        public string Enfermedad1 { get; set; }
        public string DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
    }
}
