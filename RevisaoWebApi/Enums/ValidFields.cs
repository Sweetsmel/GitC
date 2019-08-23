using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Enums
{
    public enum ValidFields
    {
        ValidaLogin,        //vai receber automaticamente o 0
        ValidaEmail,        //vai entender que quando deu a primeira virgula, o primeiro foi o 0, então este será 1
        ValidaSenha,
        ValidaNome
    }
}