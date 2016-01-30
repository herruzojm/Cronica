using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public interface IRepositorioAtributos
    {
        Task<int> CrearAtributo(Atributo atributo);
        void ActualizarAtributo(Atributo atributo);
        Task<int> ConfirmarCambios();
        Task<List<Atributo>> GetAtributos();
        Task<Atributo> GetAtributo(int atributoId);
    }
}
