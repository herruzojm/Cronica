using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class DetalleTrama : ViewComponent
    {
        private IServicioTramas _servicioTramas;

        public DetalleTrama(IServicioTramas servicioTramas)
        {
            _servicioTramas = servicioTramas;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? plantillaId)
        {
            Trama trama = await _servicioTramas.GetNuevaTrama(plantillaId);
            return View(trama);
        }
    }
}
