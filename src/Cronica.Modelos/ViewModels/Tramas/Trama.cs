using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.Tramas
{
    public class Trama
    {
        public Trama()
        {
            Atributos = new List<AtributoTrama>();
            Puntos = new List<PuntosPasaTrama>();
        }
        public int TramaId { get; set; }
        public string Descripcion { get; set; }
        public int PuntosNecesarios { get; set; }
        public int PuntosDePresionPorTiemppo { get; set; }
        public int PuntosActuales { get; set; }
        public string TextoResolucion { get; set; }
        public bool Cerrada { get; set; }        
        public virtual Personaje Personaje { get; set; }
        public virtual List<AtributoTrama> Atributos { get; set; }
        public virtual List<PuntosPasaTrama> Puntos { get; set; }
    }

    public class AtributoTrama
    {
        public int TramaId { get; set; }
        public int AtributoId { get; set; }
        public int Multiplicador { get; set; }
        public virtual Atributo Atributo { get; set; }
    }

    public class PuntosPasaTrama
    {
        public int TramaId { get; set; }
        public int PasaTramaId { get; set; }
        public int PuntosObtenidos { get; set; }
        public string Descripcion { get; set; }
    }

}
