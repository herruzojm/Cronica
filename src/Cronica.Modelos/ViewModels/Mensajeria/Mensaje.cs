using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.Mensajeria
{
    public class Mensaje
    {
        public int MensajeId { get; set; }
        public bool EsAnonimo { get; set; }
        public int RemitenteId { get; set; }
        [Display(Name = "Remitente")]
        public string NombreParaMostrar { get; set; }        
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy - hh:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreacion { get; set; }
       

        public virtual Personaje Remitente { get; set; }
        public virtual List<DestinatarioMensaje> Destinatarios { get; set; }
    }

}
