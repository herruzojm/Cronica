using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Cronica.Servicios
{
    public class ServicioUsuarios : IServicioUsuarios
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ServicioUsuarios(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApplicationUser> GetUsuarioById(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<ApplicationUser> GetUsuarioByEmail(string userEmail)
        {
            return await _userManager.FindByEmailAsync(userEmail);
        }

        public async Task<List<ApplicationUser>> GetUsuarios()
        {
            return await _userManager.Users.ToListAsync();
        }

        
    }
}
