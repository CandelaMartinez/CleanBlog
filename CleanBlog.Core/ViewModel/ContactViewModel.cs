using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Core.ViewModel
{
     public class ContactViewModel
    {
        [Required(ErrorMessage="Por favor agrega tu nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor agrega tu Email")]
        [EmailAddress(ErrorMessage ="Tienes que agregar una direccion valida de Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor agrega tu mensaje")]
        [MaxLength(500, ErrorMessage ="Tu mensaje no debe superar los 500 caracteres")]
        public string Message { get; set; }

        //page id viene del view, properties values para el form-result que viene del view como hidden
        public int ContactFormId { get; set; }


    }
}
