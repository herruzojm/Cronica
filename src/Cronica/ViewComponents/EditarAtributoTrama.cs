using Cronica.Modelos.ViewModels.Tramas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.ViewComponents
{
    public class EditarAtributoTrama : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(AtributoTrama atributo)
        {
            return View(atributo);
        }
    }
}
