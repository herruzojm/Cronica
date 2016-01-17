﻿using Cronica.ViewModels.Personaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.Trama
{
    public class PlantillaTrama
    {
        public PlantillaTrama()
        {
            Atributos = new List<AtributoPlantillaTrama>();
        }

        public int PlantillaTramaId { get; set; }
        public string Descripcion { get; set; }
        public int PuntosNecesarios { get; set; }
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
}
