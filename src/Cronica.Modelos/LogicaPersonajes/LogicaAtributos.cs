using Cronica.Modelos.ViewModels.Trama;
using Cronica.Models;
using Cronica.ViewModels.Personaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Cronica.Modelos.LogicaPersonajes
{
    public class LogicaAtributos
    {
        private CronicaDbContext _contexto;

        public LogicaAtributos(CronicaDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<int> CrearAtributo(Atributo atributo)
        {
            int resultado;
            _contexto.Atributos.Add(atributo);
            using (TransactionScope transaccion = new TransactionScope())
            {
                resultado = await _contexto.SaveChangesAsync();
                if (resultado > 0)
                {
                    resultado = await IncluirAtributoEnPersonajes(atributo);
                }
                if (resultado > 0)
                {
                    resultado = await IncluirAtributoEnPlantillasTrama(atributo);
                }
                if (resultado > 0)
                {
                    transaccion.Complete();
                }
            }           
            return resultado;
        }
        
        private async Task<int> IncluirAtributoEnPersonajes(Atributo nuevoAtributo)
        {
            var personajes = _contexto.Personajes.ToList<Personaje>();
            personajes.ForEach(p => p.Atributos.Add(
                    new AtributoPersonaje() { AtributoId = nuevoAtributo.AtributoId, PersonajeId = p.PersonajeId, Valor = 0 }
                ));
            return await _contexto.SaveChangesAsync();
        }

        private async Task<int> IncluirAtributoEnPlantillasTrama(Atributo nuevoAtributo)
        {
            var plantillasTrama = _contexto.PlantillasTrama.ToList();
            plantillasTrama.ForEach(p => p.Atributos.Add(
                    new AtributoPlantillaTrama() { AtributoId = nuevoAtributo.AtributoId, PlantillaTramaId = p.PlantillaTramaId, Multiplicador = 0 }
                ));
            return await _contexto.SaveChangesAsync();
        }

    }
}
