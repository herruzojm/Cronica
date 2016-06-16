using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.PostPartidas
{
    public class Asignacion
    {
        public Asignacion()
        {
            Asignaciones = new List<PersonajeAsignacion>();
        }
        public int AsignacionId { get; set; }
        public int PersonajeId { get; set; }
        public int PasaTramaId { get; set; }                
        public virtual Personaje Personaje { get; set; }        
        public virtual List<PersonajeAsignacion> Asignaciones { get; set; }
    }

    public class PersonajeAsignacion
    {
        public int PersonajeAsignacionId { get; set; }
        public int PersonajeId { get; set; }
        public int TramaId { get; set; }
        [Range(0, 100)]
        public int PuntosParticipacion { get; set; }
        public virtual Personaje Personaje { get; set; }
        public virtual Trama Trama { get; set; }
        public virtual Asignacion Asignacion { get; set; }
    }
    
}
