using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cronica.Modelos.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public TipoCuenta Cuenta { get; set; }
    }

    public enum TipoCuenta
    {
        Jugador,
        Narrador,
        Administrador
    }
}
