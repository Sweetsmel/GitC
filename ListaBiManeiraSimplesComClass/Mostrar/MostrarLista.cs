using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Mostrar
{
    class MostrarLista
    {
        public void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pId)
        {

            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                if (arrayBi[i, 0] == pId)
                {
                    Console.WriteLine($"Informação escolhida: Id:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");

                    return;
                }
            }


            Console.WriteLine("Infelizmente a busca pelo ID  não resultou em nenhuma informação.");
        }

    }
}
