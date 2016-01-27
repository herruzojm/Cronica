using Cronica.Modelos.ViewModels.Trama;
using Cronica.ViewModels.Personaje;
using Microsoft.AspNet.Identity;
using Microsoft.Data.Entity.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Models
{
    public class DatosIniciales
    {
        private CronicaDbContext _contexto;
        private UserManager<ApplicationUser> _userManager;

        public DatosIniciales(CronicaDbContext contexto, UserManager<ApplicationUser> userManager)
        {
            _contexto = contexto;
            _userManager = userManager;
        }


        public async Task CrearDatosAsync()
        {
            if (!_contexto.Users.Any())
            {
                var usuarioJugador = new ApplicationUser()
                {
                    UserName = "jugador@yopmail.com",
                    Email = "jugador@yopmail.com",
                    EmailConfirmed = true,
                    Cuenta = TipoCuenta.Jugador
                }; 
                await _userManager.CreateAsync(usuarioJugador, "Cronic@2016");
                var usuarioNarrador = new ApplicationUser()
                {
                    UserName = "narrador@yopmail.com",
                    Email = "narrador@yopmail.com",
                    EmailConfirmed = true,
                    Cuenta = TipoCuenta.Narrador
                };
                await _userManager.CreateAsync(usuarioNarrador, "Cronic@2016");                
            }
            if (!_contexto.Atributos.Any())
            {
                _contexto.Atributos.AddRange(
                    new Atributo() { Nombre = "Fuerza", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico },
                    new Atributo() { Nombre = "Destreza", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico },
                    new Atributo() { Nombre = "Resistencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico },
                    new Atributo() { Nombre = "Carisma", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social},
                    new Atributo() { Nombre = "Manipulación", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social },
                    new Atributo() { Nombre = "Apariencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social },
                    new Atributo() { Nombre = "Percepción", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental },
                    new Atributo() { Nombre = "Inteligencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental },
                    new Atributo() { Nombre = "Astucia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental });
                _contexto.SaveChanges();
            }
            if (!_contexto.Personajes.Any())
            {
                Personaje personaje1 = new Personaje();
                personaje1.Clan = TipoClan.Assamita;
                personaje1.Nombre = "Uno";
                _contexto.Personajes.Add(personaje1);
                _contexto.SaveChanges();
                Personaje personaje2 = new Personaje();
                personaje2.Clan = TipoClan.Lasombra;
                personaje2.Nombre = "Dos";
                _contexto.Personajes.Add(personaje2);
                _contexto.SaveChanges();
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
                _contexto.Personajes.Add(personaje3);
                _contexto.SaveChanges();
                Personaje personaje4 = new Personaje();
                personaje4.Clan = TipoClan.Ventrue;
                personaje4.Nombre = "Cuatro";
                PersonaTrasfondo tf3 = new PersonaTrasfondo();
                tf3.PersonajeJugadorId = personaje4.PersonajeId;
                tf3.PersonajeJugador = personaje4;
                tf3.TrasfondoRelacionadoId = personaje1.PersonajeId;
                tf3.TrasfondoRelacionado = personaje1;
                personaje4.Trasfondos.Add(tf3);
                _contexto.Personajes.Add(personaje4);
                _contexto.SaveChanges();
                var personajes = _contexto.Personajes.ToList();
                var atributos = _contexto.Atributos.ToList();
                foreach(Personaje personaje in personajes)
                {
                    foreach (Atributo atributo in atributos)
                    {
                        personaje.Atributos.Add(new AtributoPersonaje
                        { AtributoId = atributo.AtributoId, PersonajeId = personaje.PersonajeId, Valor = 0 });
                    }                    
                }
                _contexto.SaveChanges();
            }
            if (!_contexto.PlantillasTrama.Any())
            {
                PlantillaTrama plantilla = new PlantillaTrama();
                plantilla.Descripcion = "Aumentar Recursos";
                plantilla.PuntosDePresionPorTiemppo = 1;
                plantilla.PuntosNecesarios = 50;
                var atributos = _contexto.Atributos.ToList();
                foreach (Atributo atributo in atributos)
                {
                    plantilla.Atributos.Add(new AtributoPlantillaTrama
                    { AtributoId = atributo.AtributoId, PlantillaTramaId = plantilla.PlantillaTramaId, Multiplicador = 1 });
                }
                _contexto.PlantillasTrama.Add(plantilla);
                _contexto.SaveChanges();
            }
        }
    }
}
