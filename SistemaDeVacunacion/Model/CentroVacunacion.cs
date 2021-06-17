using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class CentroVacunacion
    {
        public CentroVacunacion()
        {
            Cita = new HashSet<Citum>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
    }
}
