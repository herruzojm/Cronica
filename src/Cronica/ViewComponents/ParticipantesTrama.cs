using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class ParticipantesTrama : ViewComponent
    {
        private IServicioPersonajes _servicioPersonajes;
        private IServicioTramas _servicioTramas;

        public ParticipantesTrama(IServicioPersonajes servicioPersonajes, IServicioTramas servicioTramas)
        {
            _servicioPersonajes = servicioPersonajes;
            _servicioTramas = servicioTramas;
        }

        public async Task<IViewComponentResult> InvokeAsync(int tramaId, TipoTrama tipoTrama)
        {
            var participantes = await _servicioTramas.GetParticipantesTrama(tramaId);
            var personajes = await _servicioPersonajes.GetPersonajesJugadores();

            VistaParticipantesTramas nuevaVista = new VistaParticipantesTramas();
            nuevaVista.TipoTrama = tipoTrama;

            if (tipoTrama == TipoTrama.Enfrentada)
            {
                var grupos = Enum.GetValues(typeof(TipoEquipo)).Cast<TipoEquipo>();
                foreach (var grupo in grupos)
                {
                    nuevaVista.GrupoParticipantes[(int)grupo] = personajes.Select(u => new SelectListItem
                    {
                        Value = u.PersonajeId.ToString(),
                        Text = u.Nombre,
                        Selected = (participantes.Where(p => p.PersonajeId == u.PersonajeId && p.Equipo == grupo).Count() > 0)
                    }).ToList();
                }
            }
            else
            {
                nuevaVista.Participantes = personajes.Select(u => new SelectListItem
                {
                    Value = u.PersonajeId.ToString(),
                    Text = u.Nombre,
                    Selected = (participantes.Where(p => p.PersonajeId == u.PersonajeId).Count() > 0)
                }).ToList();
            }
            
            return View(nuevaVista);
        }
    }
}
