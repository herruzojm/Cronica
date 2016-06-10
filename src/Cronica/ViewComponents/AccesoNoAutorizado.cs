using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class AccesoNoAutorizado : ViewComponent
    {
        public AccesoNoAutorizado()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {            
            return  View();
        }
    }
}
