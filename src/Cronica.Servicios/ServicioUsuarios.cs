﻿using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Cronica.Servicios
{
    public class ServicioUsuarios : IServicioUsuarios
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ServicioUsuarios(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> GetUserId(ClaimsPrincipal usuario)
        {
            var user = await _userManager.GetUserAsync(usuario);
            return user.Id;
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

        public async Task<List<ApplicationUser>> GetNarradores()
        {
            return await _userManager.Users.Where(u => u.Cuenta == TipoCuenta.Narrador).ToListAsync();
        }

    }
}
