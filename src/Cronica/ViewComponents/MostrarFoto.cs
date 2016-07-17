using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class MostrarFoto : ViewComponent
    {
        public MostrarFoto()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync(string foto)
        {            
            return  View("Default", foto);
        }
    }
}
