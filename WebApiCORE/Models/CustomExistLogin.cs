using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCORE.Models
{
    public class CustomExistLogin : ValidationAttribute
    {
        ContextDB dB = new ContextDB();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                Usuario user = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString());

                if (user == null)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Login já cadastrado em nossa base de dados!");
                }
            }

            return new ValidationResult($"O campo {validationContext.DisplayName} é obrigatório!");
        }
    }
}
