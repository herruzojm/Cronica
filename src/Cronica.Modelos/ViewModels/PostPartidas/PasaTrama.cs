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

        [Display(Name = "Fecha Prevista")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaPrevista { get; set; }

        [Display(Name = "Fecha de Resolución")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FechaResolucion { get; set; }

        public bool Actual { get; set; }
        public bool Resuelto { get; set; }

        [Display(Name = "Puede Resolverse")]
        [NotMapped]
        public bool PuedeResolverse
        {
            get
            {
                if (!Resuelto && Actual && FechaPrevista.Date <= DateTime.Now.Date && PostPartida != null && PostPartida.Activa)
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
