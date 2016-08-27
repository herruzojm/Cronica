using Cronica.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioUsuarios
    {
        Task<string> GetUserId(ClaimsPrincipal usuario);
        Task<ApplicationUser> GetUser(ClaimsPrincipal usuario);
        Task<List<ApplicationUser>> GetUsuarios();
        Task<ApplicationUser> GetUsuarioById(string userId);
        string GetEmailByPersonajeId(int personajeId);
        Task<ApplicationUser> GetUsuarioByEmail(string userEmail);
        Task<List<ApplicationUser>> GetNarradores();
        Task<bool> BorrarUsuario(string email);
    }
}
