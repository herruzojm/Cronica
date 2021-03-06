﻿using Microsoft.AspNetCore.Identity;

namespace Cronica.Modelos.Models
{
    public class DatosIniciales
    {
        private CronicaDbContext _contexto;
        private UserManager<ApplicationUser> _userManager;

        public DatosIniciales(CronicaDbContext contexto, UserManager<ApplicationUser> userManager)
        {
            _contexto = contexto;
            _userManager = userManager;
        }


        //public async Task CrearDatosAsync()
        //{
        //    if (!_contexto.Users.Any())
        //    {
        //        var usuarioJugador = new ApplicationUser()
        //        {
        //            UserName = "jugador@yopmail.com",
        //            Email = "jugador@yopmail.com",
        //            EmailConfirmed = true,
        //            Cuenta = TipoCuenta.Jugador
        //        }; 
        //        await _userManager.CreateAsync(usuarioJugador, "Cronic@2016");
        //        var usuarioNarrador = new ApplicationUser()
        //        {
        //            UserName = "narrador@yopmail.com",
        //            Email = "narrador@yopmail.com",
        //            EmailConfirmed = true,
        //            Cuenta = TipoCuenta.Narrador
        //        };
        //        await _userManager.CreateAsync(usuarioNarrador, "Cronic@2016");                
        //    }
        //    if (!_contexto.Atributos.Any())
        //    {
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Fuerza", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico, Orden = 1 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Destreza", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico, Orden = 2 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Resistencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Fisico, Orden = 3 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Carisma", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social, Orden = 1 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Manipulación", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social, Orden = 2 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Apariencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Social, Orden = 3});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Percepción", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental, Orden = 1 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Inteligencia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental, Orden = 2});
        //        _contexto.SaveChanges();
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Astucia", Tipo = TipoAtributo.Caracteristica, SubTipo = SubTipoAtributo.Mental, Orden = 3 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Alerta", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 1 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Atletismo", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 2});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Callejeo", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 3 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Consciencia", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 4});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Empatia", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 5 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Expresion", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 6 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Intimidacion", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden =7 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Liderazgo", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 8 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Pelea", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 9 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Subterfugio", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Talento, Orden = 10 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Armas C.C.", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 1 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Armas de Fuego", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 2 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Conducir", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 3 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Etiqueta", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 4 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Hurto", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 5 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Interpretacion", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 6 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Pericias", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 7 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Sigilo", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 8 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Supervivencia", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 9 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Trato con Animales", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Tecnica, Orden = 10 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Academicismo", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 1 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Ciencia", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 2 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Finanzas", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 3 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Informatica", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 4 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Investigacion", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 5 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Leyes", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 6});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Medicina", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 7});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Ocultismo", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 8});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Politica", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 9});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Tecnologia", Tipo = TipoAtributo.Habilidad, SubTipo = SubTipoAtributo.Conocimiento, Orden = 10});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Aliados", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 10 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Bajos Fondos", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 20 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Cultura Académica", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 30 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Finanzas", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 40 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Fuerzas del Estado", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 50 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Informatica", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 60});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Medios de Comunicacion", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 70 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Ocultismo", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 80});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Politica", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 90});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Contactos: Transporte e Infraestructuras", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 100 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Criados", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden =110 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Dominio", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 120 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Fama", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 130 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Generacion", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 140 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Identidad Alternativa", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 150 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Bajos Fondos", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 160});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Cultura Académica", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 170});
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Finanzas", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 180 });
        //        _contexto.SaveChanges();
        //        _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Fuerzas del Estado", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 190});
        //        _contexto.SaveChanges();
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Informatica", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 200});
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Medios de Comunicacion", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 210 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Ocultismo", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 220 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Politica", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 230 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Influencia: Transporte e Infraestructuras", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 240 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Mentor", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 250});
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Rebaño", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 260});
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Recursos", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 270 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Refugio: Seguridad", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 280 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Refugio: Tamaño", Tipo = TipoAtributo.Trasfondo, SubTipo = SubTipoAtributo.Conocimiento, Orden = 290 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Consciencia", Tipo = TipoAtributo.Virtud, SubTipo = SubTipoAtributo.Conocimiento, Orden = 10});
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Conviccion", Tipo = TipoAtributo.Virtud, SubTipo = SubTipoAtributo.Conocimiento, Orden = 20 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Autocontrol", Tipo = TipoAtributo.Virtud, SubTipo = SubTipoAtributo.Conocimiento, Orden = 30 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Instinto", Tipo = TipoAtributo.Virtud, SubTipo = SubTipoAtributo.Conocimiento, Orden = 40 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Coraje", Tipo = TipoAtributo.Virtud, SubTipo = SubTipoAtributo.Conocimiento, Orden = 50 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Animalismo", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 10 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Auspex", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 20 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Celeridad", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 30 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Dementacion", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 40 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Dominacion", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 50 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Extincion", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 60 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Fortaleza", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 70 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Nigromancia: Sepulcro", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 80 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Nigromancia: Cadaver Dentro del Monstruo", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 90 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Nigromancia: Podredumbre de la Tumba", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 100 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Nigromancia: Cenizas", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 110 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Nigromancia: Cenotafio", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 120 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Nigromancia: Cuatro Humores", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 130 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Nigromancia: Osario", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 140 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Nigromancia: Vitrea", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 150 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Obtenebracion", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 160 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Ofuscacion", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 170 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Potencia", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 180 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Presencia", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 190 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Quimerismo", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 200 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Serpentis", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 210 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Taumaturgia: Sangre", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 220 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Taumaturgia: Control Atmosferico", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 230 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Taumaturgia: Dominio Elemental", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 240 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Taumaturgia: Encanto de las Llamas", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 250 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Taumaturgia: Movimiento Mental", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 260 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Taumaturgia: Conjuracion", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 270 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Taumaturgia: Marte", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 280 });
        //        _contexto.SaveChanges(); _contexto.Atributos.Add(new Atributo() { Nombre = "Vicisitud", Tipo = TipoAtributo.Disciplina, SubTipo = SubTipoAtributo.Conocimiento, Orden = 290 });                    
        //        _contexto.SaveChanges();
        //    }
        //    if (!_contexto.Personajes.Any())
        //    {
        //        Personaje personaje1 = new Personaje();
        //        personaje1.Clan = TipoClan.Assamita;
        //        personaje1.Nombre = "Uno";
        //        personaje1.Activo = true;
        //        personaje1.JugadorId = _contexto.Users.Where(u => u.Cuenta == TipoCuenta.Narrador).FirstOrDefault().Id;
        //        _contexto.Personajes.Add(personaje1);
        //        _contexto.SaveChanges();
        //        Personaje personaje2 = new Personaje();
        //        personaje2.Clan = TipoClan.Lasombra;
        //        personaje2.Nombre = "Dos";
        //        personaje2.Activo = true;
        //        personaje2.JugadorId = _contexto.Users.Where(u => u.Cuenta == TipoCuenta.Narrador).FirstOrDefault().Id;
        //        _contexto.Personajes.Add(personaje2);
        //        _contexto.SaveChanges();
        //        Personaje personaje3 = new Personaje();
        //        personaje3.Clan = TipoClan.Samedi;
        //        personaje3.Nombre = "Tres";
        //        personaje3.Activo = true;
        //        personaje3.JugadorId = _contexto.Users.Where(u => u.Cuenta == TipoCuenta.Jugador).FirstOrDefault().Id;
        //        PersonaTrasfondo tf1 = new PersonaTrasfondo();
        //        tf1.PersonajeJugadorId = personaje3.PersonajeId;
        //        tf1.PersonajeJugador = personaje3;
        //        tf1.TrasfondoRelacionadoId = personaje1.PersonajeId;
        //        tf1.TrasfondoRelacionado = personaje1;
        //        tf1.TipoRelacion = TipoRelacionPersona.Contacto;
        //        PersonaTrasfondo tf2 = new PersonaTrasfondo();
        //        tf2.PersonajeJugadorId = personaje3.PersonajeId;
        //        tf2.PersonajeJugador = personaje3;
        //        tf2.TrasfondoRelacionadoId = personaje2.PersonajeId;
        //        tf2.TrasfondoRelacionado = personaje2;
        //        tf2.TipoRelacion = TipoRelacionPersona.Criado;
        //        personaje3.Seguidores.Add(tf1);
        //        personaje3.Seguidores.Add(tf2);
        //        _contexto.Personajes.Add(personaje3);
        //        _contexto.SaveChanges();
        //        Personaje personaje4 = new Personaje();
        //        personaje4.Clan = TipoClan.Ventrue;
        //        personaje4.Nombre = "Cuatro";
        //        personaje4.JugadorId = _contexto.Users.Where(u => u.Cuenta == TipoCuenta.Narrador).FirstOrDefault().Id;
        //        PersonaTrasfondo tf3 = new PersonaTrasfondo();
        //        tf3.PersonajeJugadorId = personaje4.PersonajeId;
        //        tf3.PersonajeJugador = personaje4;
        //        tf3.TrasfondoRelacionadoId = personaje1.PersonajeId;
        //        tf3.TrasfondoRelacionado = personaje1;
        //        tf3.TipoRelacion = TipoRelacionPersona.Aliado;
        //        personaje4.Seguidores.Add(tf3);
        //        _contexto.Personajes.Add(personaje4);
        //        _contexto.SaveChanges();
        //        var personajes = _contexto.Personajes.ToList();
        //        var atributos = _contexto.Atributos.ToList();
        //        foreach(Personaje personaje in personajes)
        //        {
        //            foreach (Atributo atributo in atributos)
        //            {
        //                personaje.Atributos.Add(new AtributoPersonaje
        //                { AtributoId = atributo.AtributoId, PersonajeId = personaje.PersonajeId, Valor = 0 });
        //            }                    
        //        }
        //        _contexto.SaveChanges();
        //    }
        //    if (!_contexto.PlantillasTrama.Any())
        //    {
        //        PlantillaTrama plantilla = new PlantillaTrama();
        //        plantilla.Descripcion = "Aumentar Recursos";
        //        plantilla.PuntosDePresionPorTiemppo = 1;
        //        plantilla.PuntosNecesarios = 50;
        //        var atributos = _contexto.Atributos.ToList();
        //        foreach (Atributo atributo in atributos)
        //        {
        //            plantilla.Atributos.Add(new AtributoPlantillaTrama
        //            { AtributoId = atributo.AtributoId, PlantillaTramaId = plantilla.PlantillaTramaId, Multiplicador = 1 });
        //        }
        //        _contexto.PlantillasTrama.Add(plantilla);
        //        _contexto.SaveChanges();
        //    }
        //}

    }
}
