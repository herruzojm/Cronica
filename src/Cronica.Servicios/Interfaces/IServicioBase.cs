using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioBase
    {        
        void Eliminar(Object elemento);
        Task<int> ConfirmarCambios();
        void Actualizar(Object elemento);        
    }
}
