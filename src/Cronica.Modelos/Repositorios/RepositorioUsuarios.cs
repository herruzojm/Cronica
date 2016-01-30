using Cronica.Modelos.ViewModels.Trama;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonaje;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private CronicaDbContext _contexto;

        public RepositorioUsuarios(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

       
        public List<ApplicationUser> GetUsuarios()
        {
            return _contexto.Users.ToList();
        }

        
    }
}
