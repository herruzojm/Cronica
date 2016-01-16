﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.ViewModels.Personaje
{
    public class Atributo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoAtributo Tipo { get; set; }
        public SubTipoAtributo SubTipo { get; set; }   
     
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
        Mental
    }
}