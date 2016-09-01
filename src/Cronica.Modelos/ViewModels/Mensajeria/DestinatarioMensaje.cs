using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.Mensajeria
{
    public class DestinatarioMensaje
    {
        public int DestinatarioMensajeId { get; set; }
        public int DestinatarioId { get; set; }
        public virtual int MensajeId { get; set; }
        public TipoDestinatario TipoDestinatario { get; set; }
        public EstadoMensaje EstadoMensaje { get; set; }

        public virtual Personaje Destinatario { get; set; }
        public virtual Mensaje Mensaje { get; set; }
    }

    public enum TipoDestinatario
    {
        Para,
        CopiaOculta
    }

    public enum EstadoMensaje
    {
        SinLeer,
        Leido,
        Respondido,
        Borrado
    }

}
