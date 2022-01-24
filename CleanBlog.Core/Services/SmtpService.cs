using CleanBlog.Core.Controllers;
using CleanBlog.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Logging;

namespace CleanBlog.Core.Services
{
    public class SmtpService: ISmtpService
    {
        //dependency injection para poder usar el servicio de umbraco de logging
        private readonly ILogger _logger;
        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }

        public bool SendEmail(ContactViewModel model)
        {

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();

                //configuro los campos del mail
                string toAddress = "to@test.com";
                string fromAddress = "from@test.com";
                message.Subject = $"Mensaje de: {model.Name } - {model.Email } ";
                message.Body = model.Message;
                message.To.Add(new MailAddress(toAddress, toAddress));
                message.From = new MailAddress(fromAddress, fromAddress);

                //envio el mail por smtp client
                client.Send(message);

                return true;

            }
            catch (Exception ex)
            {
                //uso el logger que meti por dependency injection
                _logger.Error(typeof(ContactSurfaceController), ex, "Error al enviar el contact form");
                return false;
            }

        }
    }
}
