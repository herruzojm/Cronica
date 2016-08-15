using Cronica.Servicios.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cronica.Servicios
{
    public class ServicioInterludios : ServicioBase, IServicioInterludios
    {
        
        public ServicioInterludios(CronicaDbContext contexto) : base(contexto)
        {            
        }

        public async Task<Interludio> GetNuevoInterludio()
        {
            Interludio interludio = new Interludio();
            return interludio;
        }

        public async Task<Interludio> GetInterludio(int interludioId)
        {
            return await _contexto.Interludios.Where(p => p.InterludioId == interludioId).FirstOrDefaultAsync();
        }

        public async Task<List<Interludio>> GetInterludios()
        {
            return await _contexto.Interludios.ToListAsync();
        }

        public void IncluirInterludio(Interludio interludio)
        {
            _contexto.Interludios.Add(interludio);
        }

        public Task<bool> ResolverInterludio(Interludio interludio)
        {
            //todo
            throw new NotImplementedException();
        }
    }
}
