﻿using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.Tramas;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.GestionPersonajes
{
    
    public class Personaje
    {
        public Personaje()
        {
            Atributos = new List<AtributoPersonaje>();
            Seguidores = new List<PersonaTrasfondo>();
            PersonajesJugadores = new List<PersonaTrasfondo>();
            TramasParticipadas = new List<ParticipantesTrama>();
        }

        public int PersonajeId { get; set; }
        public string JugadorId { get; set; }
        public bool Activo { get; set; }
        public string Nombre { get; set; }
        public string Historia { get; set; }
        public string Concepto { get; set; }
        public string Naturaleza { get; set; }
        public string Conducta { get; set; }
        public int Generacion { get; set; }
        [Display(Name = "Potencia de Sangre")]
        public int PotenciaSangre { get; set; }
        public TipoClan Clan { get; set; }
        [Display(Name = "Puntos de Sangre")]
        public int PuntosDeSangre { get; set; }
        public TipoSenda Senda { get; set; }
        [Display(Name = "Valor en Senda")]
        public int ValorSenda { get; set; }
        public int Voluntad { get; set; }
        public int Experiencia { get; set; }        
        public string Meritos { get; set; }
        public string Defectos { get; set; }
        public string Virtud { get; set; }
        public string Foto { get; set; }
        [NotMapped]
        public IFormFile Imagen { set; get; }
        public virtual List<AtributoPersonaje> Atributos { get; set; }
        public virtual List<PersonaTrasfondo> Seguidores { get; set; }
        public virtual List<PersonaTrasfondo> PersonajesJugadores { get; set; }
        public virtual ApplicationUser Jugador { get; set; }
        public virtual List<ParticipantesTrama> TramasParticipadas { get; set; }

    }

    public class AtributoPersonaje
    {
        public int PersonajeId { get; set; }
        public int AtributoId { get; set; }
        [Range(0, 10, ErrorMessage="El valor debe ser entre 0 y 10")]
        public int Valor { get; set; } = 0;
        [Display(Name = "Valor en Trama")]
        public int ValorEnTrama { get; set; } = 0;
        public string Descripcion { get; set; }
        public virtual Atributo Atributo { get; set; }

    }    

    public class PersonaTrasfondo
    {
        public int PersonajeJugadorId { get; set; }
        public virtual Personaje PersonajeJugador { get; set; }
        public int TrasfondoRelacionadoId { get; set; }
        public virtual Personaje TrasfondoRelacionado { get; set; }
        public TipoRelacionPersona TipoRelacion { get; set; }
    }

    public class SeguidorPotencial
    {
        public int SeguidorId { get; set; }
        public string Nombre { get; set; }
    }

    public enum TipoClan
    {
        Assamita,
        [Display(Name = "Assamita Antitribu")]
        AssamitaAntitribu,
        Brujah,
        [Display(Name = "Brujah Antitribu")]
        BrujahAntitribu,
        Caitif,
        Gangrel,
        [Display(Name = "Gangrel Antitribu")]
        GangrelAntitribu,
        Giovanni,
        [Display(Name = "Heraldo de las Calaveras")]
        HeraldoDeLasCalaveras,
        Lasombra,
        [Display(Name = "Lasombra Antitribu")]
        LasombraAntitribu,
        Malkavian,
        [Display(Name = "Malkavian Antitribu")]
        MalkavianAntitribu,
        Nosferatu,
        [Display(Name = "Nosferatu Antitribu")]
        NosferatuAntitribu,
        Pander,
        Ravnos,
        [Display(Name = "Ravnos Antitribu")]
        RavnosAntitribu,
        Samedi,
        [Display(Name = "Seguidor de Set")]
        SeguidorDeSet,
        [Display(Name = "Serpiente de la Luz")]
        SerpienteDeLaLuz,
        Toreador,
        [Display(Name = "Toreador Antitribu")]
        ToreadorAntitribu,
        Tremere,
        [Display(Name = "Tremere Antitribu")]
        TremereAntitribu,
        Tzimisce,
        Ventrue,
        [Display(Name = "Ventrue Antitribu")]
        VentrueAntitribu
    }

    public enum TipoSenda
    {
        Humanidad,
        [Display(Name = "Poder y la Voz Interior")]
        PoderVozInterior
    }

    public enum TipoRelacionPersona
    {
        Aliado,
        Contacto,
        Criado,
        Mentor
    }
}
