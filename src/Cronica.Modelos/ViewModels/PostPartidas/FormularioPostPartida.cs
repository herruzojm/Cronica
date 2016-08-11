using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.PostPartidas
{
    public class FormularioPostPartida
    {
        public int FormularioPostPartidaId { get; set; }
        public int PostPartidaId { get; set; }
        public string JugadorId { get; set; }
        public int PersonajeId { get; set; }
        public string NarradorEncargadoId { get; set; }
        public bool Tramitado { get; set; }
        public bool Enviado { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaEnvio { get; set; }
        [StringLength(9000)]
        public string Resumen { get; set; }
        public string Acuerdos { get; set; }
        public string InformacionClave { get; set; }
        public string PeticionTramas { get; set; }
        [Range(0, 10, ErrorMessage = "El valor debe ser entre 0 y 10")]
        public int ValoracionPartida { get; set; }
        public string CosasBien { get; set; }
        public string CosasMal { get; set; }
        public string ComentariosNarrador { get; set; }
        [NotMapped]
        public bool PuedeModificarse
        {
            get
            {
                return (Enviado == false);
            }
        }
        public virtual PostPartida PostPartida { get; set; }
        public virtual ApplicationUser Jugador { get; set; }
        public virtual Personaje Personaje { get; set; }
        public virtual ApplicationUser NarradorEncargado { get; set; }
    }

}
