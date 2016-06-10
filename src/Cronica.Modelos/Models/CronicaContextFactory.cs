using Microsoft.DotNet.Cli.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Cronica.Modelos.Models
{
    public class CronicaContextFactory : IDbContextFactory<CronicaDbContext>
    {

        public CronicaDbContext Create()
        {

            var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json").Build();
            var connectionStringConfig = builder.Build();            

            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer(connectionStringConfig["ConnectionStrings:DefaultConnection"]); 

            return new CronicaDbContext(options.Options);
        }
    }
}
