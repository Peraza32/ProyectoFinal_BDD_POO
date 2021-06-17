using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class Ciudadano
    {
        public Ciudadano()
        {
            Cita = new HashSet<Citum>();
            Discapacidads = new HashSet<Discapacidad>();
            Enfermedads = new HashSet<Enfermedad>();
            ProcesoDeVacunacions = new HashSet<ProcesoDeVacunacion>();
        }

        public string Dui { get; set; }
        public string Nombre { get; set; }
        public string NumeroIdentificador { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Discapacidad> Discapacidads { get; set; }
        public virtual ICollection<Enfermedad> Enfermedads { get; set; }
        public virtual ICollection<ProcesoDeVacunacion> ProcesoDeVacunacions { get; set; }
    }
}
