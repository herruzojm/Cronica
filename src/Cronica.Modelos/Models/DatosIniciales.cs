using Cronica.Modelos.ViewModels.Trama;
using Cronica.ViewModels.Personaje;
using Microsoft.Data.Entity.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Models
{
    public static class DatosIniciales
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var contexto = (CronicaDbContext)serviceProvider.GetService(typeof(CronicaDbContext));

            if (!contexto.Atributos.Any())
            {
                contexto.Atributos.AddRange(
                    new Atributo() { Nombre = "Fuerza", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico },
                    new Atributo() { Nombre = "Destreza", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico },
                    new Atributo() { Nombre = "Resistencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico },
                    new Atributo() { Nombre = "Carisma", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social},
                    new Atributo() { Nombre = "Manipulación", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social },
                    new Atributo() { Nombre = "Apariencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social },
                    new Atributo() { Nombre = "Percepción", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental },
                    new Atributo() { Nombre = "Inteligencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental },
                    new Atributo() { Nombre = "Astucia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental });
                contexto.SaveChanges();
            }
            if (!contexto.Personajes.Any())
            {
                Personaje personaje1 = new Personaje();
                personaje1.Clan = TipoClan.Assamita;
                personaje1.Nombre = "Uno";
                contexto.Personajes.Add(personaje1);
                contexto.SaveChanges();
                Personaje personaje2 = new Personaje();
                personaje2.Clan = TipoClan.Lasombra;
                personaje2.Nombre = "Dos";
                contexto.Personajes.Add(personaje2);
                contexto.SaveChanges();
                Personaje personaje3 = new Personaje();
                personaje3.Clan = TipoClan.Samedi;
                personaje3.Nombre = "Tres";
                PersonaTrasfondo tf1 = new PersonaTrasfondo();
                tf1.PersonajeJugadorId = personaje3.PersonajeId;
                tf1.PersonajeJugador = personaje3;
                tf1.TrasfondoRelacionadoId = personaje1.PersonajeId;
                tf1.TrasfondoRelacionado = personaje1;
                PersonaTrasfondo tf2 = new PersonaTrasfondo();
                tf2.PersonajeJugadorId = personaje3.PersonajeId;
                tf2.PersonajeJugador = personaje3;
                tf2.TrasfondoRelacionadoId = personaje2.PersonajeId;
                tf2.TrasfondoRelacionado = personaje2;
                personaje3.Trasfondos.Add(tf1);
                personaje3.Trasfondos.Add(tf2);
                contexto.Personajes.Add(personaje3);
                contexto.SaveChanges();
                Personaje personaje4 = new Personaje();
                personaje4.Clan = TipoClan.Ventrue;
                personaje4.Nombre = "Cuatro";
                PersonaTrasfondo tf3 = new PersonaTrasfondo();
                tf3.PersonajeJugadorId = personaje4.PersonajeId;
                tf3.PersonajeJugador = personaje4;
                tf3.TrasfondoRelacionadoId = personaje1.PersonajeId;
                tf3.TrasfondoRelacionado = personaje1;
                personaje4.Trasfondos.Add(tf3);
                contexto.Personajes.Add(personaje4);
                contexto.SaveChanges();
                var personajes = contexto.Personajes.ToList();
                var atributos = contexto.Atributos.ToList();
                foreach(Personaje personaje in personajes)
                {
                    foreach (Atributo atributo in atributos)
                    {
                        personaje.Atributos.Add(new AtributoPersonaje
                        { AtributoId = atributo.AtributoId, PersonajeId = personaje.PersonajeId, Valor = 0 });
                    }                    
                }
                contexto.SaveChanges();
            }
            if (!contexto.PlantillasTrama.Any())
            {
                PlantillaTrama plantilla = new PlantillaTrama();
                plantilla.Descripcion = "Aumentar Recursos";
                plantilla.PuntosDePresionPorTiemppo = 1;
                plantilla.PuntosNecesarios = 50;
                var atributos = contexto.Atributos.ToList();
                foreach (Atributo atributo in atributos)
                {
                    plantilla.Atributos.Add(new AtributoPlantillaTrama
                    { AtributoId = atributo.AtributoId, PlantillaTramaId = plantilla.PlantillaTramaId, Multiplicador = 1 });
                }                
                contexto.PlantillasTrama.Add(plantilla);
                contexto.SaveChanges();
            }
        }
    }
}
