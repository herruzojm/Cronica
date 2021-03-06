﻿using Cronica.Servicios.Interfaces;
using Cronica.Modelos.Models;
using Cronica.Modelos.ViewModels.GestionPersonajes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Cronica.Modelos.ViewModels;

namespace Cronica.Servicios
{
    public class ServicioPersonajes : ServicioBase, IServicioPersonajes
    {

        private const int SubterfugioId = 19;
        private const int InformticaId = 33;

        private IHostingEnvironment _environment;

        public ServicioPersonajes(CronicaDbContext contexto, IHostingEnvironment environment) : base(contexto)
        {
            _environment = environment;
        }

        public async Task<List<Enumerado>> GetEnumeradoPersonajes()
        {
            return await _contexto.Personajes.Select(p => new Enumerado { Id = p.PersonajeId.ToString(), Descripcion = p.Nombre }).ToListAsync();
        }

        public async Task<List<Personaje>> GetPersonajes()
        {
            return await _contexto.Personajes.Include(p => p.Jugador).ToListAsync();
        }

        public async Task<Personaje> GetNuevoPersonaje()
        {
            Personaje personaje = new Personaje();
            var atributos = await _contexto.Atributos.ToListAsync();
            foreach (Atributo atributo in atributos)
            {
                personaje.Atributos.Add(new AtributoPersonaje()
                { Valor = 0, PersonajeId = personaje.PersonajeId, AtributoId = atributo.AtributoId, Atributo = atributo });
            }
            personaje.Activo = true;
            return personaje;
        }

        public async Task<Personaje> GetPersonajeCompleto(int personajeId)
        {
            Personaje personaje = await _contexto.Personajes
                .Include(p => p.TramasParticipadas).ThenInclude(tp => tp.Trama)
                .Include(p => p.Seguidores).ThenInclude(s => s.TrasfondoRelacionado)
                .Include(p => p.Atributos).ThenInclude(ap => ap.Atributo)
                .SingleAsync(p => p.PersonajeId == personajeId);
            return personaje;
        }

        public async Task<Personaje> GetPersonaje(int personajeId)
        {
            Personaje personaje = await _contexto.Personajes.SingleAsync(m => m.PersonajeId == personajeId);
            return personaje;
        }

        public void IncluirPersonaje(Personaje personaje)
        {
            _contexto.Personajes.Add(personaje);
        }

        public async Task<List<Personaje>> GetPersonajesJugadores()
        {
            return await _contexto.Personajes.Include(p => p.Jugador)
                .Where(p => p.Jugador.Cuenta == TipoCuenta.Jugador && p.Activo == true).ToListAsync();
        }

        public async Task<List<Personaje>> GetPNJs()
        {
            return await _contexto.Personajes.Include(p => p.Jugador)
                .Where(p => p.Jugador.Cuenta == TipoCuenta.Narrador && p.Activo == true).ToListAsync();
        }

        public async Task<bool> ActualizarPersonaje(Personaje personaje)
        {
            bool resultado = true;

            if (personaje.Imagen != null && personaje.Imagen.Length > 0)
            {
                if (await GuardarImagen(personaje.Imagen, personaje.PersonajeId))
                {
                    personaje.Foto = personaje.PersonajeId.ToString() + ".png";
                }
                else
                {
                    resultado = false;
                    if (_mensaje == string.Empty)
                    {
                        _mensaje = $"Uppss... tenemos un problema grabando la imagen";
                    }                    
                }
            }
            if (resultado)
            {
                Actualizar(personaje);
                await ConfirmarCambios();
            }

            return resultado;
        }

        public bool PuedeHacerEnvioAnonimo(int personajeId)
        {
            return _contexto.Personajes.Include(p => p.Atributos).Where(p => p.PersonajeId == personajeId &&
                    p.Atributos.Any(a => (a.AtributoId == SubterfugioId && a.Valor >= 3) || (a.AtributoId == InformticaId && a.Valor >= 3))).Count() > 0;
                    
        }

        private async Task<bool> GuardarImagen(IFormFile imagen, int personajeId)
        {
            bool resultado = true;

            string carpetaImagenes = Path.Combine(_environment.WebRootPath, "personajes");
            string extension = Path.GetExtension(imagen.FileName);

            if (!EsExtensionValida(extension))
            {
                resultado = false;
                _mensaje = "La extension de la imagen no es valida. Solo se admiten JPG, JPEG, GIF y PNG";
            }
            if (resultado && imagen.Length > 1024*1024)
            {
                resultado = false;
                _mensaje = "Te has colado; la imagen no debe ser mayor de 1 mega";
            }
            if ( resultado && imagen.Length > 0)
            {
                using (var fileStream = new FileStream(Path.Combine(carpetaImagenes, personajeId.ToString() + ".png"), FileMode.Create))
                {
                    await imagen.CopyToAsync(fileStream);
                }
            }

            return resultado;
        }

        private bool EsExtensionValida(string extension)
        {
            switch (extension.ToUpper())
            {
                case ".JPG":
                case ".JPEG":
                case ".GIF":
                case ".PNG":
                    return true;
                default:
                    return false;
            }

        }

    }
}
