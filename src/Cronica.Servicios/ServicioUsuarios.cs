using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Cronica.Servicios
{
    public class ServicioUsuarios : IServicioUsuarios
    {
        private CronicaDbContext _contexto;

        public ServicioUsuarios(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<ApplicationUser> GetUsuarioById(string userId)
        {
            return await _contexto.Users.SingleAsync(u => u.Id == userId);
        }

        public async Task<ApplicationUser> GetUsuarioByEmail(string userEmail)
        {
            return await _contexto.Users.SingleAsync(u => u.Email == userEmail);
        }

        public async Task<List<ApplicationUser>> GetUsuarios()
        {
            return await _contexto.Users.ToListAsync();
        }

        
    }
}
