using Cronica.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioUsuarios
    {
        Task<List<ApplicationUser>> GetUsuarios();
        Task<ApplicationUser> GetUsuarioById(string userId);
        Task<ApplicationUser> GetUsuarioByEmail(string userEmail);
    }
}
