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
    public class EntrePartida
    {
        public EntrePartida()
        {
            Interludios = new List<Interludio>();
            TramasActivas = new List<Trama>();
        }

        public int EntrePartidaId { get; set; }

        [Display(Name = "Fecha de Inicio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Fecha de Fin")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }

        public bool Cerrada { get; set; }
        public bool Activa {get;set;}

        public virtual List<Interludio> Interludios { get; set; }
        public virtual List<Trama> TramasActivas { get; set; }
    }
}
