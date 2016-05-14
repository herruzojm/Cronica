using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class EditarAtributoPersonaje : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(AtributoPersonaje atributo)
        {
            return View(atributo);
        }
    }
}
