using Cronica.Modelos.ViewModels.Tramas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios
{
    public interface IRepositorioPlantillasTrama
    {
        Task<List<PlantillaTrama>> GetPlantillasTrama();
        Task<PlantillaTrama> GetNuevaPlantilla();
        Task<PlantillaTrama> GetPlantillaTrama(int personajeId);
        void IncluirPlantillaTrama(PlantillaTrama plantillaTrama);
        Task<int> ConfirmarCambios();
        void ActualizarPlantillaTrama(PlantillaTrama plantillaTrama);
        void EliminarPlantillaTrama(PlantillaTrama plantillaTrama);
    }
}
