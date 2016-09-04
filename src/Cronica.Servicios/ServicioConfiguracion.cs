using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Cronica.Servicios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Cronica.Modelos.ViewModels.Manage;

namespace Cronica.Servicios
{
    public class ServicioConfiguracion : ServicioBase, IServicioConfiguracion
    {        
        public ServicioConfiguracion(CronicaDbContext contexto) : base(contexto)
        {
        }

        public async Task<Configuracion> GetConfiguracion()
        {
            return await _contexto.Configuracion.FirstOrDefaultAsync();
        }
    }
}
