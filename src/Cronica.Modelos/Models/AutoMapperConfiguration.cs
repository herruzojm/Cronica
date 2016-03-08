using AutoMapper;
using Cronica.Modelos.ViewModels.Tramas;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Models
{
    public class AutoMapperConfiguration : Profile
    {
        
        protected override void Configure()
        {
            CreateMap<Trama, PlantillaTrama>().ReverseMap();
            CreateMap<AtributoTrama, AtributoPlantillaTrama>().ReverseMap();
        }
    }
}
