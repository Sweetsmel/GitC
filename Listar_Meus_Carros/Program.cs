using Listar_Meus_Carros.MeusCarros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_Meus_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> listaAdd = new List<Carros>();


            var escolhaInicial = MenuInicial();

            while (true)
            {
                switch (escolhaInicial) //ou (listaAdd?)
                {
                    case "1": { AdicionaCarros(); } break;
                    case "2": { listaAdd.RetornaAno(); } break;
                    case "3": { listaAdd.ListarCarros(); } break;
                    case "4": { return; }
                }
                escolhaInicial = MenuInicial();
            }

        }





    }
}
