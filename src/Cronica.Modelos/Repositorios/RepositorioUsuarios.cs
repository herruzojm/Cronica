using Cronica.Modelos.Repositorios.Interfaces;
using Cronica.Modelos.ViewModels.Tramas;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
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
