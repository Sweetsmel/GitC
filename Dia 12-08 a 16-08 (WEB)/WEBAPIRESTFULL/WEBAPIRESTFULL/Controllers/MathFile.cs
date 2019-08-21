using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPIRESTFULL.Models;
using WEBAPIRESTFULL.Utils;

namespace WEBAPIRESTFULL.Controllers
{
    public class MathFile : Single<MathFile>        // : Single<MathFile>  é a Herança. INSTANCIA(resolve problemas)
    {
        BibliotecaContextDB bibliotecaContextDB = new BibliotecaContextDB();
        public int QuantidadeUsuarios()
        {
            return bibliotecaContextDB
                   .Usuarios.Count();       //contar os usuarios
        }
    }
}