﻿using Cronica.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronica.Modelos.Repositorios.Interfaces
{
    public interface IRepositorioUsuarios
    {
        List<ApplicationUser> GetUsuarios();
    }
}
