using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.PostPartidas
{
    public class PasaTrama
    {
        public int PasaTramaId { get; set; }
        public DateTime FechaPrevista { get; set; }
        public DateTime FechaResolucion { get; set; }        
        public bool Resuelto { get; set; }
        public virtual PostPartida PostPartida { get; set; }
    }
}
