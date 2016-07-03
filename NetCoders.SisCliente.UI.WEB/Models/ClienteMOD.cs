using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetCoders.SisCliente.UI.WEB.Models
{
    public class ClienteMOD
    {
        public int Codigo { get; set; }

        //O Data Anottations Required, Serve pra dizer que a minha propriedade
        //è obrigatória.
        [Required(ErrorMessage = "Ow digita o nome ae campeão")]
        public string Nome { get; set; }

        [Required]
        //O Data Annotations EmailAddress serve para dizer que a minha
        //Propriedade é um Email, ou seja, ele vai fazer uma verficação
        //simples, se o campo é um email
        [EmailAddress]
        public string Email { get; set; }
    }
}