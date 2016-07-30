﻿
using Cronica.Servicios.Interfaces;
using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace Cronica.Servicios
{
    public class ServicioEmail : IServicioEmail
    {
        public void EnviarAltaCuenta(string cuentaUsuario, string password)
        {
            var mensage = new MimeMessage();
            mensage.From.Add(new MailboxAddress("Verum In Sanguine", "VerumInSanguine@gmail.com"));
            mensage.To.Add(new MailboxAddress(cuentaUsuario, cuentaUsuario));
            mensage.Subject = "Cuenta de usuario en Verum In Sanguine";
            mensage.Body = new TextPart("html") { Text = TextoAltaCuenta(cuentaUsuario, password) };
            EnviarMensaje(mensage);                       
        }

        private void EnviarMensaje(MimeMessage mensaje)
        {
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.sendgrid.net", 25, false);

                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate(
                    System.Environment.GetEnvironmentVariable("SENDGRID_USER"),
                    System.Environment.GetEnvironmentVariable("SENDGRID_PASS")
                    );

                client.Send(mensaje);
                client.Disconnect(true);
            }
        }

        private string TextoAltaCuenta(string cuentaUsuario, string password)
        {
            return @"
                <h3>¡¡Buenas!!</h3>

                <p>Alguien del equipo de narración de <a href=""http://veruminsanguine.azurewebsites.net/"" target=""_blank"">Verum In Sanguine</a> ha creado una cuenta para tí.</p>

                <p>Tus datos de acceso son:</p>
                <ul>

                    <li> Usuario: " + cuentaUsuario + @"</li>

                    <li> Contraseña: " + password + @"</li>
                </ul>
                <p>Te recomendamos encarecidamente que <a href=""http://veruminsanguine.azurewebsites.net/Account/Login"" target=""_blank"">entres</a> y cambies tu contraseña tan pronto como puedas.</p>
                <p>Si todo esto no te suena de nada y crees que es un error, es que seguramente sea un error.
                Te agradecriamos que nos lo hiceras saber enviandonos un correo a <a href=""mailto:VerumInSanguine@gmail.com"">VerumInSanguine@gmail.com</a> para que podamos corregir las cosas y azotar adecuadamente al becario responsable.</p>
                <p>¡Nos vemos!</p> ";

		}
    }
}