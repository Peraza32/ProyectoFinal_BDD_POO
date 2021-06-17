using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class EfectoSecundario
    {
        public EfectoSecundario()
        {
            EfectoPresentados = new HashSet<EfectoPresentado>();
        }

        public int Id { get; set; }
        public string Efecto { get; set; }

        public virtual ICollection<EfectoPresentado> EfectoPresentados { get; set; }
    }
}
