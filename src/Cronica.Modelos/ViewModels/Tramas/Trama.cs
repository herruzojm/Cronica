﻿using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.PostPartidas;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.Tramas
{
    public class Trama
    {
        public Trama()
        {
            Atributos = new List<AtributoTrama>();
            Puntos = new List<PuntosInterludio>();
            Participantes = new List<ParticipantesTrama>();
        }        

        public int TramaId { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Tipo de Trama")]
        public TipoTrama TipoTrama { get; set; }
        public string Descripcion { get; set; }
        [Display(Name = "Puntos Necesarios")]
        public int PuntosNecesarios { get; set; }
        [Display(Name = "Puntos de Presión Por Tiempo")]
        public int PuntosDePresionPorTiemppo { get; set; }
        [Display(Name = "Puntos Actuales")]
        public int PuntosActuales { get; set; }
        [Display(Name = "Texto de Resolución")]
        public string TextoResolucion { get; set; }
        public bool Cerrada { get; set; }
        public int? PlantillaId { get; set; }
        public virtual List<ParticipantesTrama> Participantes { get; set; }
        public virtual PlantillaTrama Plantilla { get; set; }
        public virtual List<AtributoTrama> Atributos { get; set; }
        public virtual List<PuntosInterludio> Puntos { get; set; }
    }


    public class ParticipantesTrama
    {
        public int TramaId { get; set; }
        public int PersonajeId { get; set; }
        public TipoEquipo Equipo { get; set; }
        public virtual Personaje Personaje { get; set; }
        public virtual Trama Trama { get; set; }
    }

    public class AtributoTrama
    {
        public int TramaId { get; set; }
        public int AtributoId { get; set; }
        public int Multiplicador { get; set; }
        public virtual Atributo Atributo { get; set; }
    }

    public class PuntosInterludio
    {
        public int TramaId { get; set; }
        public int InterludioId { get; set; }
        public int PersonajeId { get; set; }
        [Display(Name = "Puntos Obtenidos")]
        public int PuntosObtenidos { get; set; }
        public string Descripcion { get; set; }
        public virtual Interludio Interludio { get; set; }
    }

    public enum TipoEquipo
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H
    }

    public class VistaParticipantesTramas
    {
        private string[] _participantes;
        public TipoTrama TipoTrama { get; set; }
        public string Participante { get; set; }
        public string[] ParticipantesIds
        {
            get
            {
                if (_participantes == null && Participante != null)
                {
                    _participantes = new string[] {Participante };
                }
                return _participantes;
            }
            set
            {
                _participantes = value;
            }
        }                
        public IEnumerable<SelectListItem> Participantes { get; set; }
        public string[][] GrupoParticipantesIds { get; set; } = new string[Enum.GetNames(typeof(TipoEquipo)).Length][];
        public List<SelectListItem>[] GrupoParticipantes { get; set; } = new List<SelectListItem>[Enum.GetNames(typeof(TipoEquipo)).Length];
    }

    public class VistaTramas
    {
        public VistaTramas()
        {
            Tramas = new List<VistaListaTrama>();
        }

        public int PersonajeId { get; set; }
        [Display(Name = "Nombre Personaje")]
        public string NombrePersonaje { get; set; }
        public IEnumerable<VistaListaTrama> Tramas { get; set; }

    }

    public class VistaListaTrama
    {
        public int TramaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Display(Name = "Texto Resolución")]
        public string TextoResolucion { get; set; }
    }


}
