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
            var contexto = (CronicaDbContext)serviceProvider.GetService(typeof (CronicaDbContext));
            var servicio = (IRelationalDatabaseCreator)serviceProvider.GetService(typeof(IRelationalDatabaseCreator));
            if (servicio.Exists())
            {
                if (!contexto.Atributos.Any())
                {
                    contexto.Atributos.Add(new Atributo() { Nombre = "Fuerza", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico });
                    contexto.SaveChanges();
                }
            }
        }
    }
}
