using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class Cabina
    {
        public Cabina()
        {
            Encargados = new HashSet<Encargado>();
            Sesions = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public virtual ICollection<Encargado> Encargados { get; set; }
        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
