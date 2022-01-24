using CleanBlog.Core.Services;
using CleanBlog.Core.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Logging;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace CleanBlog.Core.Controllers
{
     public class ContactSurfaceController: SurfaceController
    {

        //uso la clase que cree con la interface, para usar el servicio logger y el metodo que cree de sendEmail
        private readonly ISmtpService _smtpService;
       

        public ContactSurfaceController(ISmtpService smtpService)
        {
            _smtpService = smtpService;
        }

        //render the Form
        public ActionResult RenderForm()
        {
            //instancio el modelo que uso, le doy valor al campo diciendole que es el id de la pagina actual
            ContactViewModel model = new ContactViewModel() { ContactFormId = CurrentPage.Id };
            //devuelve la partial view y el model que tiene el id de esa pagina
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);

        }

        public ActionResult RenderForm2(ContactViewModel model)
        {
            //devuelve la partial view y el model que tiene el id de esa pagina
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);

        }

        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool succes = false;
            //call algo to send the email: depending on the result: succes o error message
            //si el modelo es correcto segun las data anotations que le puse: succes sera el resultado de si se puedo enviar el mail o no(metodo)
            if (ModelState.IsValid)
            {
                succes = _smtpService.SendEmail(model);
            }

            //obtengo del modelo el campo ContactFormId: me da la contact page
            var contactPage = UmbracoContext.Content.GetById(false, model.ContactFormId);

            //acceso a los campos del document type contact con sus alias
            var succesMessage = contactPage.Value<IHtmlString>("succesMessageP");
            var errorMessage = contactPage.Value<IHtmlString>("errorMessageP");

            //devuelvo la partial, si succes es true: despliego succesMessage, sino despliego errorMessage
            //el result partial espera el htmlstring que le estoy pasando. succes o error message
            return PartialView("~/Views/Partials/Contact/result.cshtml", succes ? succesMessage : errorMessage);

         
        }

       

    }
}
