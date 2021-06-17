using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class TipoDosi
    {
        public TipoDosi()
        {
            Cita = new HashSet<Citum>();
            ProcesoDeVacunacions = new HashSet<ProcesoDeVacunacion>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<ProcesoDeVacunacion> ProcesoDeVacunacions { get; set; }
    }
}
