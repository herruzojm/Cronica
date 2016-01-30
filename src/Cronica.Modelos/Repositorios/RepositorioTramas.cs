using Cronica.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.Tramas;
using Microsoft.Data.Entity;

namespace Cronica.Modelos.Repositorios
{
    public class RepositorioTramas : IRepositorioTramas
    {
        private CronicaDbContext _contexto;

        public RepositorioTramas(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public void ActualizarTrama(Trama trama)
        {
            _contexto.Update(trama);            
        }

        public async Task<int> ConfirmarCambios()
        {
            return await _contexto.SaveChangesAsync();
        }

        public void EliminarTrama(Trama tramaId)
        {
            _contexto.Remove(tramaId);
        }

        public async Task<Trama> GetTrama(int tramaId)
        {
            return await _contexto.Tramas.SingleAsync(t => t.TramaId == tramaId);
        }

        public async Task<List<Trama>> GetTramas()
        {
            return await _contexto.Tramas.ToListAsync();
        }

        public void IncluirTrama(Trama trama)
        {
            _contexto.Tramas.Add(trama);
        }
    }
}
