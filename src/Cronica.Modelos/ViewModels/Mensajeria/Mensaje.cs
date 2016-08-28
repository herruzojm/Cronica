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


    public class MensajeBandejaEntrada
    {
        public int MensajeId { get; set; }
        public int PersonajeId { get; set; }
        [Display(Name = "Anonimo")]
        public bool EsAnonimo { get; set; }
        public string Remitente { get; set; }
        [Display(Name = "Enviado como...")]
        public string EnviadoComo { get; set; }
        public string Asunto { get; set; }
        [Display(Name = "Fecha Envio")]
        public DateTime FechaEnvio { get; set; }
        public EstadoMensaje Estado { get; set; }
    }

    public class MensajeBandejaSalida
    {
        public int MensajeId { get; set; }
        public int PersonajeId { get; set; }
        [Display(Name = "Anonimo")]
        public bool EsAnonimo { get; set; }
        [Display(Name = "Enviado como...")]
        public string EnviadoComo { get; set; }
        [Display(Name = "Enviado a...")]
        public string EnviadoA { get; set; }
        public string Asunto { get; set; }
        [Display(Name = "Fecha Envio")]
        public DateTime FechaEnvio { get; set; }
    }

    public class VistaMensaje
    {
        public int MensajeId { get; set; }
        public bool EsAnonimo { get; set; }
        public string Remitente { get; set; }
        public string RemitenteReal { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Destinatarios { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }

    }

}
