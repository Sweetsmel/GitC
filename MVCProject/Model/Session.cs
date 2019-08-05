using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Model
{
    public static class Session      //coloquei como estatica(static) dentro do nosso processo todas as telas conseguem acessar
    {
        public static Usuario user; //se o login existir ele vai constinuar
    }
}
