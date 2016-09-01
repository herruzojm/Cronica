using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.Mensajeria;
using Cronica.Modelos.ViewModels.PostPartidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioMensajeria : IServicioBase
    {
        Task<List<MensajeBandejaEntrada>> GetMensajesRecibidos(int personajeId);
        Task<List<MensajeBandejaSalida>> GetMensajesEnviados(int personajeId);
        Task<VistaMensaje> GetVistaMensaje(int mensajeId, int personajeId, ApplicationUser usuario);
        Task<VistaMensaje> GetVistaMensaje(int mensajeId, ApplicationUser usuario);
        Task<Mensaje> GetMensaje(int mensajeId);
        Task<bool> EnviarMensaje(Mensaje mensaje, List<string> para, List<string> copiaOculta);
        void EnviarEmails(List<string> Para, List<string> CopiaOculta);
    }
}
