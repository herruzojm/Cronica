﻿using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

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

            services.AddMemoryCache();
            //services.AddSession(o =>
            //{
            //    o.IdleTimeout = TimeSpan.FromSeconds(10);
            //});
            services.AddMvc();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Jugador", policy => policy.AddRequirements(new TipoCuentaRequirement(TipoCuenta.Jugador)));
                options.AddPolicy("Narrador", policy => policy.Requirements.Add(new TipoCuentaRequirement(TipoCuenta.Narrador)));
                options.AddPolicy("Administrador", policy => policy.Requirements.Add(new TipoCuentaRequirement(TipoCuenta.Administrador)));
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
            services.AddScoped<IServicioEntrePartidas, ServicioEntrePartidas>();
            services.AddScoped<IServicioInterludios, ServicioInterludios>();
            services.AddScoped<IServicioSeguidores, ServicioSeguidores>();
            services.AddScoped<IServicioAsignaciones, ServicioAsignaciones>();
            services.AddScoped<IServicioMensajeria, ServicioMensajeria>();
            services.AddScoped<IServicioEmail, ServicioEmail>();
            services.AddScoped<IServicioConfiguracion, ServicioConfiguracion>();
            services.AddSingleton<IMapper>(sp => _mapperConfiguration.CreateMapper());
            services.AddSingleton<IAuthorizationHandler, TipoCuentaHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory )
        {

            //app.UseSession();

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
            cookiesOptions.CookieName = "VerumInSanguine";
            app.UseCookieAuthentication(cookiesOptions);
            
            var ci = new CultureInfo("es-ES");
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            
            RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions();
            localizationOptions.DefaultRequestCulture = new RequestCulture(ci);
            localizationOptions.SupportedCultures.Add(ci);
            localizationOptions.SupportedUICultures.Add(ci);
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
                    name: "EntrePartidas",
                    template: "EntrePartidas",
                    defaults: new { controller = "EntrePartidas", action = "Index" });
                routes.MapRoute(
                    name: "AbrirEntrePartida",
                    template: "EntrePartidas/Edit/{id}",
                    defaults: new { controller = "EntrePartidas", action = "Edit" });
                routes.MapRoute(
                    name: "CrearEntrePartida",
                    template: "EntrePartidas/Create",
                    defaults: new { controller = "EntrePartidas", action = "Create" });                            

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
                    name: "VerMensaje",
                    template: "VerMensaje/{id}/{personajeId}",
                    defaults: new { controller = "Mensajeria", action = "VerMensaje" });

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
