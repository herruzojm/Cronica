﻿using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class BandejaSalida : ViewComponent
    {

        private IServicioMensajeria _servicioMensajeria;

        public BandejaSalida(IServicioMensajeria servicioMensajeria)
        {
            _servicioMensajeria = servicioMensajeria;
        }

        public async Task<IViewComponentResult> InvokeAsync(int personajeId)
        {
            return View(await _servicioMensajeria.GetMensajesEnviados(personajeId));
        }
    }
}
