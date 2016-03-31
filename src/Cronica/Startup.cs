using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Cronica.Modelos.Models;
using Cronica.Services;
using Cronica.Servicios.Interfaces;
using Microsoft.AspNet.Http;
using System.Reflection;
using System.Globalization;
using Microsoft.AspNet.Localization;
using AutoMapper;
using Cronica.Authorization;
using Microsoft.AspNet.Authorization;
using Cronica.Servicios;

namespace Cronica
{
    public class Startup
    {

        private MapperConfiguration _mapperConfiguration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
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
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]))
                .AddDbContext<CronicaDbContext>(options =>
                    options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 15, 0);
                options.User.RequireUniqueEmail = true;                
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();             

            services.AddMvc().AddPrecompiledRazorViews(GetType().GetTypeInfo().Assembly).AddViewLocalization().AddDataAnnotationsLocalization();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Narrador", policy => policy.Requirements.Add(new TipoCuentaRequirement(TipoCuenta.Narrador)));
            });

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
            services.AddScoped<DatosIniciales>();
            services.AddScoped<IServicioUsuarios, ServicioUsuarios>();
            services.AddScoped<IServicioPersonajes, ServicioPersonajes>();
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
        public async void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory, 
            DatosIniciales datosIniciales )
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

                // For more details on creating database during deployment see http://go.microsoft.com/fwlink/?LinkID=615859
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

            app.UseIISPlatformHandler(options => options.AuthenticationDescriptions.Clear());

            app.UseStaticFiles();

            app.UseIdentity();
            
            app.UseCookieAuthentication(options =>
                {
                    options.AuthenticationScheme = "Cookies";
                    options.LogoutPath = new PathString("/Home/Index");
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/Account/AccesoDenegado");
                }
            );

            var ci = new CultureInfo("es-ES");
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";

            app.UseRequestLocalization(new RequestCulture(ci));
            
            ConfigurarRutas(app);
                      
            await datosIniciales.CrearDatosAsync();
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
                    defaults: new { controller = "Personajes", action = "MiPersonaje" });
                routes.MapRoute(
                    name: "MisTramas",
                    template: "MisTramas",
                    defaults: new { controller = "Personajes", action = "MisTramas" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }

}
