using System;
using System.Net.Mail;
using System.Net.Mime;

namespace sendmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GestorCorreo gestor = new GestorCorreo();

            //Correo con archivos adjuntos
            //MailMessage correo = new MailMessage("jaltez97@gmail.com",
            //                                     "raul.armas@unmsm.edu.pe",
            //                                     "Archivo de configuracíon",
            //                                     "Por favor verificar adjunto.");

            //string ruta = @"C:\Users\raula\source\repos\sendmail\sendmail\" + "Configuracion.xml";
            //Attachment adjunto = new Attachment(ruta, MediaTypeNames.Application.Xml);
            //correo.Attachments.Add(adjunto);
            //gestor.EnviarCorreo(correo);

            // Correo con HTML
            gestor.EnviarCorreo("jaltez97@gmail.com",
                                "Prueba1",
                                "Mensaje en texto plano");

            Console.WriteLine("Prueba de correo ok");
            //// Correo de texto  
            //gestor.EnviarCorreo("raul.armas@unmsm.edu.pe",
            //                    "Prueba2",
            //                    "<h1>Mensaje en HTML<h1><p>Contenido</p>",
            //                    true);
        }
    }
}
