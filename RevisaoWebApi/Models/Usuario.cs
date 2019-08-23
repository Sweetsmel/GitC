using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Models
{
    public class Usuario : UserControls
    {
        [Key]                                               //atributo pode definir várias informações sobre isso, como se transformasse em uma classe
        public int Id { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaNome)]   //ou no lugar de ValidaNome poderia ser o 3, mas seria mais dificil na hora de compreender
        public string Nome { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaLogin)]
        public string Login { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaSenha)]
        public string Senha { get; set; }
    }
}