using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class ProcesoDeVacunacion
    {
        public ProcesoDeVacunacion()
        {
            EfectoPresentados = new HashSet<EfectoPresentado>();
        }

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraVacunacion { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public int TipoDosis { get; set; }
        public string DuiCiudadano { get; set; }

        public virtual Ciudadano DuiCiudadanoNavigation { get; set; }
        public virtual TipoDosi TipoDosisNavigation { get; set; }
        public virtual ICollection<EfectoPresentado> EfectoPresentados { get; set; }
    }
}
