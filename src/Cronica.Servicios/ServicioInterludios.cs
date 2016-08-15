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

        public async Task<PasaTrama> GetNuevoInterludio()
        {
            PasaTrama interludio = new PasaTrama();
            return interludio;
        }

        public async Task<PasaTrama> GetInterludio(int interludioId)
        {
            return await _contexto.PasaTramas.Where(p => p.PasaTramaId == interludioId).FirstOrDefaultAsync();
        }

        public async Task<List<PasaTrama>> GetInterludios()
        {
            return await _contexto.PasaTramas.ToListAsync();
        }

        public void IncluirPasaTrama(PasaTrama interludio)
        {
            _contexto.PasaTramas.Add(interludio);
        }

        public Task<bool> ResolverInterludio(PasaTrama interludio)
        {
            //todo
            throw new NotImplementedException();
        }
    }
}
