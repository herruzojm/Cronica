using Cronica.Servicios.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Cronica.Modelos.Models;
using Microsoft.EntityFrameworkCore;

namespace Cronica.Servicios
{
    public class ServicioSeguidores : ServicioBase, IServicioSeguidores
    {
        public ServicioSeguidores(CronicaDbContext contexto) : base(contexto)
        {
        }

        public async Task<PersonaTrasfondo> GetSeguidor(int personajeId, int seguidorId)
        {
            return await _contexto.Seguidores
                .Include(s => s.PersonajeJugador)
                .Include(s => s.TrasfondoRelacionado)
                .SingleAsync(s => s.PersonajeJugadorId == personajeId && s.TrasfondoRelacionadoId == seguidorId);
        }

        public async Task<List<SeguidorPotencial>> GetSeguidoresPotenciales(int personajeId)
        {            
            return await _contexto.Personajes.Where(seguidor => seguidor.Jugador.Cuenta == TipoCuenta.Narrador && 
                (_contexto.Seguidores.Where(s => s.PersonajeJugadorId == personajeId && s.TrasfondoRelacionadoId == seguidor.PersonajeId).Count() == 0))
                .Select(p=> new SeguidorPotencial { SeguidorId = p.PersonajeId, Nombre = p.Nombre })
                .ToListAsync();
        }

        public void GuardarSeguidor(PersonaTrasfondo seguidor)
        {
            _contexto.Seguidores.Add(seguidor);
        }
    }
}
