﻿using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.PostPartidas;
using Microsoft.AspNet.Mvc.Rendering;
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
            Participantes = new List<ParticipantesTrama>();
        }        

        public int TramaId { get; set; }
        public string Nombre { get; set; }
        public TipoTrama TipoTrama { get; set; }
        public string Descripcion { get; set; }
        public int PuntosNecesarios { get; set; }
        public int PuntosDePresionPorTiemppo { get; set; }
        public int PuntosActuales { get; set; }
        public string TextoResolucion { get; set; }
        public bool Cerrada { get; set; }
        public int? PlantillaId { get; set; }
        public virtual List<ParticipantesTrama> Participantes { get; set; }
        public virtual PlantillaTrama Plantilla { get; set; }
        public virtual List<AtributoTrama> Atributos { get; set; }
        public virtual List<PuntosPasaTrama> Puntos { get; set; }
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

    public class PuntosPasaTrama
    {
        public int TramaId { get; set; }
        public int PasaTramaId { get; set; }
        public int PersonajeId { get; set; }
        public int PuntosObtenidos { get; set; }
        public string Descripcion { get; set; }
        public virtual PasaTrama PasaTrama { get; set; }
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


}
