using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaCompacta.CriandoLista
{
    class ListaUma
    {
        string[,] novaLista;

        public ListaUma()
        {
            novaLista = new string[5,2];

            CarregaListaUma();
        }

        public void CarregaListaUma()
        {
            for (int i = 0; i < novaLista.GetLength(0); i++)
            {

                novaLista[i,0] = DateTime.Now.ToString($"dd/MM/yyyy");
                novaLista[i, 1] = DateTime.Now.ToString($"hh:mm:ss.fff");

                Console.WriteLine($"Data: {novaLista[i, 0]} e Hora: {novaLista[i, 1]}");
            }

            //foreach (var item in novaLista)
            //    Console.WriteLine(item);

            for (int i = 0; i < novaLista.GetLength(0); i++)
            {
                //novaLista[i,0] = string.Empty;
                //novaLista[i, 1] = string.Empty;

                foreach (var item in novaLista)

                    Console.WriteLine($"Data: {novaLista[i, 0]} e Hora: {novaLista[i, 1]}");

                Console.ReadKey();
            }
        }
    }
}
