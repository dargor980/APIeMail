using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Api_email
{
    class SendEmail
    {
        static void Main(string[] args)
        {
            String usuario, contraseña, destinatario, asunto, mensaje;

            Console.WriteLine("\t\t---------------------------------------");
            Console.WriteLine("\t\tEnviar Correo Electronico");
            Console.WriteLine("\t\t---------------------------------------");

            Console.WriteLine("\n");
            Console.Write("\t\tIngresa tu correo electronico: ");
            usuario = Console.ReadLine();
            Console.Write("\t\tIngresa tu password: ");
            contraseña = Console.ReadLine();
            Console.Write("\t\tDestinatario: ");
            destinatario = Console.ReadLine();
            Console.Write("\t\tAsunto: ");
            asunto = Console.ReadLine();
            Console.Write("\t\tMensaje: ");
            mensaje = Console.ReadLine();

            MailMessage correo = new MailMessage(usuario, destinatario, asunto, mensaje);

            SmtpClient servidor = new SmtpClient("smtp.gmail.com");
            NetworkCredential credenciales = new NetworkCredential(usuario, contraseña);
            servidor.Credentials = credenciales;
            servidor.EnableSsl = true;
            servidor.Send(correo);
            Console.WriteLine("\t\tCorreo enviado de manera exitosa");
            correo.Dispose();
           

        }
    }
}
