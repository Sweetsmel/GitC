using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCORE.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int Id { get; set; }

        [CustomNameValidator]
        public string Nome { get; set; }

        [RegularExpression(pattern: @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [CustomExistLogin]
        public string Login { get; set; }

        [MaxLength(16, ErrorMessage = "O campo excedeu o limite de caracteres \"16\".")]
        [MinLength(8, ErrorMessage = "O campo não atende a quantidade mínima de caracteres \"8\".")]
        public string Senha { get; set; }
    }
}
