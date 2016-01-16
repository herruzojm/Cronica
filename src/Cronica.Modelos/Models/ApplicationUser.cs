﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Cronica.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public TipoCuenta Cuenta { get; set; }
    }

    public enum TipoCuenta
    {
        Jugador,
        Narrador
    }
}