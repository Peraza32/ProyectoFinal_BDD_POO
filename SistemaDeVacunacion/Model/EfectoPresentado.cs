using System;
using System.Collections.Generic;

#nullable disable

namespace SistemaDeVacunacion.Model
{
    public partial class EfectoPresentado
    {
        public int IdProcesoVacunacion { get; set; }
        public int IdEfectoSecundario { get; set; }

        public virtual EfectoSecundario IdEfectoSecundarioNavigation { get; set; }
        public virtual ProcesoDeVacunacion IdProcesoVacunacionNavigation { get; set; }
    }
}
