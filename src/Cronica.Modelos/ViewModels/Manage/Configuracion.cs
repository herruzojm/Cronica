using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.ViewModels.Manage
{
    public class Configuracion
    {
        public int ConfiguracionId { get; set; }
        [Display(Name = "Dirección base de la web")]
        [DataType(DataType.Url)]
        public string DireccionBase { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Range(0, 200, ErrorMessage = "El valor debe ser entre 0 y 200 %")]
        [Display(Name = "Porcentaje de puntos para Aliados")]
        public int PorcentajeAliados { get; set; }

        [Range(0, 200, ErrorMessage = "El valor debe ser entre 0 y 200 %")]
        [Display(Name = "Porcentaje de puntos para Contactos")]
        public int PorcentajeContactos { get; set; }

        [Range(0, 200, ErrorMessage = "El valor debe ser entre 0 y 200 %")]
        [Display(Name = "Porcentaje de puntos para Influencia")]
        public int PorcentajeInfluencia { get; set; }

        [Display(Name = "Porcentaje de puntos para Mentor")]
        [Range(0, 200, ErrorMessage = "El valor debe ser entre 0 y 200 %")]
        public int PorcentajeMentor { get; set; }
    }
}
