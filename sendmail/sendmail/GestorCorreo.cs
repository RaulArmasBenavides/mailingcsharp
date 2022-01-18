using Microsoft.Extensions.Configuration;
using MimeKit;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace sendmail
{
    public class GestorCorreo
    {

        private SmtpClient cliente;
        private static IConfiguration Configuration { get; set; }
        private MailMessage email;
        public GestorCorreo()
        {
        }

        //using MailKit
        public void EnviarCorreo(string destinatario, string asunto, string mensaje, bool esHtlm = true)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("SISTEMA CERSEU", "imanol123valera@gmail.co"));
            // message.To.Add(new MailboxAddress("Ing. Carlos Mamani", "12170115@unmsm.edu.pe"));
            message.To.Add(new MailboxAddress("Ing. Carlos Mamani", "raularmasbx@gmail.com"));
            message.Subject = "Notificación de registro de evento";

            message.Body = new TextPart("plain")
            {
                Text = @"Se le comunica que ha sido regsitrada una nueva actividad en el sistema de eventos del CERSEU"
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);
                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
              
                client.Authenticate("imanol123valera@gmail.com", "xxxxxxxx");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
