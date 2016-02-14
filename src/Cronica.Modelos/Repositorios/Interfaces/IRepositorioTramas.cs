﻿using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public interface IRepositorioTramas
    {
        Task<List<Trama>> GetTramas();
        Task<List<Trama>> GetTramasPersonaje(int personajeId);
        Task<Trama> GetTrama(int tramaId);
        void IncluirTrama(Trama trama);
        Task<int> ConfirmarCambios();
        void ActualizarTrama(Trama trama);
        void EliminarTrama(Trama trama);
        Task<Trama> GetNuevaTrama(int? plantillaId);
    }
}