﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.GestionPersonajes
{
    public class Atributo
    {
        public int AtributoId { get; set; }
        public string Nombre { get; set; }
        public TipoAtributo Tipo { get; set; }
        public SubTipoAtributo SubTipo { get; set; }   
        public int Orden { get; set; }
     
    }

    public enum TipoAtributo
    {
        Caracteristica,
        Habilidad,
        Trasfondo,
        Disciplina,
        Virtud,
        Otros
    }

    public enum SubTipoAtributo
    {
        Fisico,
        Social,
        Mental,
        Talento,
        Tecnica,
        Conocimiento
    }
}
