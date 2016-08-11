using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Cronica.Modelos.ViewModels.GestionPersonajes;

namespace Cronica.Servicios
{
    public class ServicioUsuarios : ServicioBase, IServicioUsuarios
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ServicioUsuarios(UserManager<ApplicationUser> userManager, CronicaDbContext contexto) : base(contexto)
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

        public async Task<bool> BorrarUsuario(string jugadorId)
        {
            bool resultado = false;

            ApplicationUser usuario = await GetUsuarioById(jugadorId);            
            Personaje personaje = _contexto.Personajes.Where(p => p.JugadorId == jugadorId).FirstOrDefault();

            if (personaje != null)
            {
                personaje.JugadorId = GetIdAdministrador();
                personaje.Activo = false;
                Actualizar(personaje);
            }
            Eliminar(usuario);
            resultado = (await ConfirmarCambios() > 0);
            
            return resultado;
        }

        private string GetIdAdministrador()
        {
            return _contexto.Users.Where(u => u.Cuenta == TipoCuenta.Administrador).FirstOrDefault().Id;
        }


    }
}
