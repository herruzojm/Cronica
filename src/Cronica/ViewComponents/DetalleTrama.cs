using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IViewComponentResult> InvokeAsync(int? plantillaTramaId, Trama trama)
        {
            if (plantillaTramaId.HasValue)
            {
                Trama nuevaTrama = await _servicioTramas.GetNuevaTrama(plantillaTramaId);
                return View(nuevaTrama);
            }
            else
            {
                return View(trama);
            }
            
        }
        
    }
}
