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
            _contexto.Update(elemento);
        }

        public async Task<int> ConfirmarCambios()
        {
            return await _contexto.SaveChangesAsync();
        }

        public void Eliminar(object elemento)
        {
            _contexto.Remove(elemento);
        }
    }
}
