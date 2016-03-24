using Cronica.Servicios.Interfaces;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.Data.Entity;

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
