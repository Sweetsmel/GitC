using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)                                                         //ponto de acesso da memória, não será publico, então não por "public"
        {
            /*new AquiMostraJoinha().MetodoInicialDoJoinha();

            new AquiMostraJoinha().MetodoDoisPontoZero(true);

            new AquiMostraJoinha().MetodoDoisPontoZero(false);*/
                                                                                                //Operação pesada como leitura e gravação na memória.
            var outroCaraParaRealizarOTeste = new AquiMostraJoinha().TesteUmOperadorLegal();
                                                                                                //Contagem de todos os registros da nossa lista.
            var tamanhoDaLista = outroCaraParaRealizarOTeste.Length;
                                                                                                //Nosso FOR agora está mais rápido
            for (int i = 0; i < tamanhoDaLista; i++)                                            //Já puxou o length na variavel
            {
                Console.WriteLine(outroCaraParaRealizarOTeste[i]);                              //Pediu de uma vez para fritar 20 ovos ao invés de fazer vários pedidos um por um.
            }

            Console.ReadKey();
        }
    }
}
