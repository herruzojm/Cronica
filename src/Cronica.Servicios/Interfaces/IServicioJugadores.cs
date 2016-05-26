﻿using Cronica.Modelos.ViewModels.GestionPersonajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioJugadores : IServicioBase
    {
        Task<Personaje> GetMiPersonaje(string jugadorId);
        Task<Personaje> GetMisTramas(string jugadorId);
    }
}