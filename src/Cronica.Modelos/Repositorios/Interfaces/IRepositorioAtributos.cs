using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios.Interfaces
{
    public interface IRepositorioAtributos : IRepositorioBase
    {
        Task<int> CrearAtributo(Atributo atributo);
        Task<List<Atributo>> GetAtributos();
        Task<Atributo> GetAtributo(int atributoId);
    }
}
