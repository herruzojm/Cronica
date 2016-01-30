using Cronica.Modelos.ViewModels.PostPartida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.PostPartida
{
    public class PostPartida
    {
        public PostPartida()
        {
            PasaTramas = new List<PasaTrama>();
            Tramas = new List<TramaActiva>();
        }

        public int PostPartidaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Cerrada { get; set; }
        public virtual List<PasaTrama> PasaTramas { get; set; }
        public virtual List<TramaActiva> Tramas { get; set; }
    }
}
