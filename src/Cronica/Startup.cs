using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Cronica.Modelos.Models;
using Cronica.Authorization;
using Cronica.Services;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Cronica.Servicios;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace Cronica
{
    public class Startup
    {

        private MapperConfiguration _mapperConfiguration { get; set; }
        
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                builder.AddUserSecrets();
            }            

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();

            _mapperConfiguration = new MapperConfiguration(configuracion =>
            {
                configuracion.AddProfile(new AutoMapperConfiguration());
            });
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Add framework services.            
            services
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")))
                .AddDbContext<CronicaDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

           
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 15, 0);
                options.User.RequireUniqueEmail = true;                
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();             

            services.AddMvc();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Jugador", policy => policy.AddRequirements(new TipoCuentaRequirement(TipoCuenta.Jugador)));
                options.AddPolicy("Narrador", policy => policy.Requirements.Add(new TipoCuentaRequirement(TipoCuenta.Narrador)));
            });

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();            
            services.AddScoped<IServicioUsuarios, ServicioUsuarios>();
            services.AddScoped<IServicioPersonajes, ServicioPersonajes>();
            services.AddScoped<IServicioJugadores, ServicioJugadores>();
            services.AddScoped<IServicioAtributos, ServicioAtributos>();
            services.AddScoped<IServicioPlantillasTrama, ServicioPlantillasTrama>();
            services.AddScoped<IServicioTramas, ServicioTramas>();
            services.AddScoped<IServicioPostPartidas, ServicioPostPartidas>();
            services.AddScoped<IServicioPasaTramas, ServicioPasaTramas>();
            services.AddScoped<IServicioSeguidor, ServicioSeguidor>();
            services.AddSingleton<IMapper>(sp => _mapperConfiguration.CreateMapper());
            services.AddSingleton<IAuthorizationHandler, TipoCuentaHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory )
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            if (env.IsDevelopment())
            {
                loggerFactory.AddDebug(LogLevel.Information);
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                loggerFactory.AddDebug(LogLevel.Debug);
                app.UseExceptionHandler("/Home/Error");

                try
                {
                    using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                        .CreateScope())
                    {
                        serviceScope.ServiceProvider.GetService<CronicaDbContext>()
                             .Database.Migrate();
                    }
                }
                catch { }
            }
            
            app.UseStaticFiles();

            app.UseIdentity();

            CookieAuthenticationOptions cookiesOptions = new CookieAuthenticationOptions();
            cookiesOptions.AuthenticationScheme = "Cookies";            
            cookiesOptions.LogoutPath = new PathString("/Home/Index");
            cookiesOptions.LoginPath = new PathString("/Home/Index");
            cookiesOptions.AccessDeniedPath = new PathString("/Home/Index");
            cookiesOptions.CookieName = "VerumEstSanguis";
            app.UseCookieAuthentication(cookiesOptions);
            
            var ci = new CultureInfo("es-ES");
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";

            Microsoft.AspNetCore.Builder.RequestLocalizationOptions localizationOptions = new Microsoft.AspNetCore.Builder.RequestLocalizationOptions();
            localizationOptions.DefaultRequestCulture = new RequestCulture(ci);
            app.UseRequestLocalization(localizationOptions);
            
            ConfigurarRutas(app);
                                  
        }

        public void ConfigurarRutas(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {                
                routes.MapRoute(
                    name: "AbrirPersonaje",
                    template: "Personajes/Edit/{id}",
                    defaults: new { controller = "Personajes", action = "Edit" });
                routes.MapRoute(
                    name: "Personajes",
                    template: "Personajes",
                    defaults: new { controller = "Personajes", action = "Index" });

                routes.MapRoute(
                    name: "PostPartidas",
                    template: "PostPartidas",
                    defaults: new { controller = "PostPartidas", action = "Index" });
                routes.MapRoute(
                    name: "AbrirPostPartida",
                    template: "PostPartidas/Edit/{id}",
                    defaults: new { controller = "PostPartidas", action = "Edit" });
                routes.MapRoute(
                    name: "CrearPostPartida",
                    template: "PostPartidas/Create",
                    defaults: new { controller = "PostPartidas", action = "Create" });

                routes.MapRoute(
                    name: "CrearPasaTrama",
                    template: "PasaTramas/Create/{id}",
                    defaults: new { controller = "PasaTramas", action = "Create" });                

                routes.MapRoute(
                    name: "MiPersonaje",
                    template: "MiPersonaje",
                    defaults: new { controller = "Jugadores", action = "MiPersonaje" });
                routes.MapRoute(
                    name: "MisTramas",
                    template: "MisTramas",
                    defaults: new { controller = "Jugadores", action = "MisTramas" });
                routes.MapRoute(
                    name: "Asignaciones",
                    template: "Asignaciones",
                    defaults: new { controller = "Jugadores", action = "Asignaciones" });
                routes.MapRoute(
                    name: "DetalleTrama",
                    template: "DetalleTrama/{personajeId}/{tramaId}",
                    defaults: new { controller = "Jugadores", action = "DetalleTrama" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
              .UseKestrel()
              .UseContentRoot(Directory.GetCurrentDirectory())
              .UseIISIntegration()
              .UseStartup<Startup>()
              .Build();

            host.Run();
        }

    }

}
