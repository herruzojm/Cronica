using Cronica.Modelos.ViewModels.Trama;
using Cronica.Models;
using Cronica.ViewModels.Personaje;
using System.Linq;
using System.Threading.Tasks;

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
            _contexto.Atributos.Add(atributo);
            IncluirAtributoEnPersonajes(atributo);
            IncluirAtributoEnPlantillasTrama(atributo);
            return await _contexto.SaveChangesAsync();                
        }
        
        private void IncluirAtributoEnPersonajes(Atributo nuevoAtributo)
        {
            var personajes = _contexto.Personajes.ToList<Personaje>();
            personajes.ForEach(p => p.Atributos.Add(
                    new AtributoPersonaje() { AtributoId = nuevoAtributo.AtributoId, PersonajeId = p.PersonajeId, Valor = 0 }
                ));            
        }

        private void IncluirAtributoEnPlantillasTrama(Atributo nuevoAtributo)
        {
            var plantillasTrama = _contexto.PlantillasTrama.ToList();
            plantillasTrama.ForEach(p => p.Atributos.Add(
                    new AtributoPlantillaTrama() { AtributoId = nuevoAtributo.AtributoId, PlantillaTramaId = p.PlantillaTramaId, Multiplicador = 0 }
                ));            
        }

    }
}
