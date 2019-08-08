using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WPFCadastro.Controller
{
    public class ValidatesCustom
    {
        public static bool ValidEmail(string email)
        {
            var stringRegEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regexemail = new Regex(stringRegEmail);
            return regexemail.IsMatch(email);
        }
        public static bool ValidNumero(string numero)   //ou @"^\\+(?:[0-9] ?){6,14}[0-9]$"

        {
            var stringRegNumero = @"^\\+(?:[0-9] ?){6,14}[0-9]$";
            Regex regexnumero = new Regex(stringRegNumero);
            return regexnumero.IsMatch(numero);
        }
    }
}
