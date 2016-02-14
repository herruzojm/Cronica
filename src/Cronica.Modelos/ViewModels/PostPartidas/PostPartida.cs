using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.PostPartidas
{
    public class PostPartida
    {
        public PostPartida()
        {
            PasaTramas = new List<PasaTrama>();
            TramasActivas = new List<Trama>();
        }

        public int PostPartidaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Cerrada { get; set; }
        [NotMapped]
        public bool Activa {
            get
            {
                if (FechaInicio.Date <= DateTime.Now.Date && DateTime.Now.Date <= FechaFin.Date)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public virtual List<PasaTrama> PasaTramas { get; set; }
        public virtual List<Trama> TramasActivas { get; set; }
    }
}
