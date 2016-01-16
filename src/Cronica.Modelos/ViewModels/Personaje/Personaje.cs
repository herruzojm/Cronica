using Cronica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.ViewModels.Personaje
{
    
    public class Personaje
    {
        public Personaje()
        {
            Atributos = new List<AtributoPersonaje>();
            Trasfondos = new List<PersonaTrasfondo>();
            PersonajesJugadores = new List<PersonaTrasfondo>();
        }

        public int Id { get; set; }
        public string JugadorId { get; set; }
        public bool Activo { get; set; }
        public string Nombre { get; set; }
        public string Historia { get; set; }
        public string Concepto { get; set; }
        public string Naturaleza { get; set; }
        public string Conducta { get; set; }
        public int Generacion { get; set; }
        public int PotenciaSangre { get; set; }
        public TipoClan Clan { get; set; }
        public int PuntosDeSangre { get; set; }
        public TipoSenda Senda { get; set; }
        public int ValorSenda { get; set; }
        public int Experiencia { get; set; }        
        public string Meritos { get; set; }
        public string Defectos { get; set; }
        public virtual List<AtributoPersonaje> Atributos { get; set; }
        public virtual List<PersonaTrasfondo> Trasfondos { get; set; }
        public virtual List<PersonaTrasfondo> PersonajesJugadores { get; set; }
        public virtual ApplicationUser Jugador { get; set; }

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

    public class AtributoPersonaje
    {
        public int Id { get; set; }
        public int PersonajeId { get; set; }
        public int AtributoId { get; set; }
        public int Valor { get; set; } = 0;

        public virtual Atributo Atributo { get; set; }

    }    

    public class PersonaTrasfondo
    {
        public int PersonajeJugadorId { get; set; }
        public virtual Personaje PersonajeJugador { get; set; }
        public int TrasfondoRelacionadoId { get; set; }
        public virtual Personaje TrasfondoRelacionado { get; set; }
    }


    public class PersonajeCompleto
    {
        public Personaje Personaje { get; set; }
        public List<AtributoPersonaje> Atributos { get; set; }
    }

}
