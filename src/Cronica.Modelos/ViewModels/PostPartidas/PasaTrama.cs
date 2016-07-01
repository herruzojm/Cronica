using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.PostPartidas
{
    public class PasaTrama
    {
        public int PasaTramaId { get; set; }
        public DateTime FechaPrevista { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public bool Actual { get; set; }
        public bool Resuelto { get; set; }
        [NotMapped]
        public bool PuedeResolverse
        {
            get
            {
                if (!Resuelto && Actual && FechaPrevista.Date >= DateTime.Now.Date && PostPartida != null && PostPartida.Activa)
                {
                    return true;
                }
                return false;
            }
        }
        public virtual int PostPartidaId { get; set; }
        public virtual PostPartida PostPartida { get; set; }
    }
}
