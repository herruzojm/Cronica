using Cronica.Servicios.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.PostPartidas;
using Cronica.Modelos.Models;
using Microsoft.EntityFrameworkCore;

namespace Cronica.Servicios
{
    public class ServicioPasaTramas : ServicioBase, IServicioPasaTramas
    {
        
        public ServicioPasaTramas(CronicaDbContext contexto) : base(contexto)
        {            
        }

        public async Task<PasaTrama> GetNuevoPasaTrama()
        {
            PasaTrama pasaTrama = new PasaTrama();
            return pasaTrama;
        }

        public async Task<PasaTrama> GetPasaTrama(int pasaTramaId)
        {
            return await _contexto.PasaTramas.Where(p => p.PasaTramaId == pasaTramaId).FirstOrDefaultAsync();
        }

        public async Task<List<PasaTrama>> GetPasaTramas()
        {
            return await _contexto.PasaTramas.ToListAsync();
        }

        public void IncluirPasaTrama(PasaTrama pasaTrama)
        {
            _contexto.PasaTramas.Add(pasaTrama);
        }
    }
}
