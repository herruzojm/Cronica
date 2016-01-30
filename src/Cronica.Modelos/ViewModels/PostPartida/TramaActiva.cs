using Cronica.Modelos.ViewModels.GestionPersonaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.PostPartida
{
    public class TramaActiva
    {
        public TramaActiva()
        {
            Atributos = new List<AtributoTramaActiva>();
            Puntos = new List<PuntosPasaTrama>();
        }
        public int TramaActivaId { get; set; }
        public string Descripcion { get; set; }
        public int PuntosNecesarios { get; set; }
        public int PuntosDePresionPorTiemppo { get; set; }
        public int PuntosActuales { get; set; }
        public string TextoResolucion { get; set; }
        public bool Cerrada { get; set; }        
        public virtual Personaje Personaje { get; set; }
        public virtual List<AtributoTramaActiva> Atributos { get; set; }
        public virtual List<PuntosPasaTrama> Puntos { get; set; }
    }

    public class AtributoTramaActiva
    {
        public int TramaActivaId { get; set; }
        public int AtributoId { get; set; }
        public int Multiplicador { get; set; }
        public virtual Atributo Atributo { get; set; }
    }

    public class PuntosPasaTrama
    {
        public int TramaActivaId { get; set; }
        public int PasaTramaId { get; set; }
        public int PuntosObtenidos { get; set; }
        public string Descripcion { get; set; }
    }

}
