using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class Empleado
    {
        public Empleado()
        {
            Cita = new HashSet<Citum>();
            Encargados = new HashSet<Encargado>();
            Sesions = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int IdTipo { get; set; }

        public virtual TipoEmpleado IdTipoNavigation { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Encargado> Encargados { get; set; }
        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
