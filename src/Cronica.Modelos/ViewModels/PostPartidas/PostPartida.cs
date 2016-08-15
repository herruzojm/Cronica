using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Fecha de Inicio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha de Fin")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }

        public bool Cerrada { get; set; }
        public bool Activa {get;set;}

        public virtual List<PasaTrama> PasaTramas { get; set; }
        public virtual List<Trama> TramasActivas { get; set; }
    }
}
