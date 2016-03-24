using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Servicios.Interfaces
{
    public interface IServicioPlantillasTrama : IServicioBase
    {
        Task<List<PlantillaTrama>> GetPlantillasTrama();
        Task<PlantillaTrama> GetNuevaPlantilla();
        Task<PlantillaTrama> GetPlantillaTrama(int personajeId);
        void IncluirPlantillaTrama(PlantillaTrama plantillaTrama);
    }
}
