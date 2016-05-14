using Cronica.Modelos.Models;
using Cronica.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios
{
    public class ServicioBase : IServicioBase
    {
        protected CronicaDbContext _contexto;

        public ServicioBase(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Actualizar(object elemento)
        {            
            try
            {
                _contexto.Update(elemento);
            }
            catch (Exception ex)
            {
                
            }
        }

        public async Task<int> ConfirmarCambios()
        {
            try
            {
                return await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void Eliminar(object elemento)
        {
            _contexto.Remove(elemento);
        }
    }
}
