using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.Tramas
{
    public class PlantillaTrama
    {
        public PlantillaTrama()
        {
            Atributos = new List<AtributoPlantillaTrama>();
        }

        public int PlantillaTramaId { get; set; }
        [Display(Name = "Tipo de Trama")]
        public TipoTrama TipoTrama { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Display(Name = "Puntos Necesarios")]
        public int PuntosNecesarios { get; set; }
        [Display(Name = "Puntos de Presión Por Tiempo")]
        public int PuntosDePresionPorTiemppo { get; set; }
        public virtual List<AtributoPlantillaTrama> Atributos { get; set; }
    }

    public class AtributoPlantillaTrama
    {
        public int PlantillaTramaId { get; set; }
        public int AtributoId { get; set; }
        public int Multiplicador { get; set; }
        public virtual Atributo Atributo { get; set; }
    }

    public enum TipoTrama
    {
        Individual,
        Colaborativa,
        Enfrentada
    }

}
