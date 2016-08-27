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
        Task<List<Mensaje>> GetMensajesEnviados(int personajeId);
        Task<bool> EnviarMensaje(Mensaje mensaje, List<string> para, List<string> copiaOculta);
    }
}
