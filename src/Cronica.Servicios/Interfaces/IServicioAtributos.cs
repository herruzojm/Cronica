using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioAtributos : IServicioBase
    {
        Task<int> CrearAtributo(Atributo atributo);
        Task<List<Atributo>> GetAtributos();
        Task<Atributo> GetAtributo(int atributoId);
    }
}
