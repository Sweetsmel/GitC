using SistemaCantinaGG.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
            Carteira continha = new Carteira(20);

            while (continha.Saldo > 0.00)
            {
                Menu();

                var valor = 0.00;

                switch (Console.ReadLine())
                {
                    case "1": { valor = 5.00; } break;
                    case "2": { valor = 2.00; } break;
                    case "3": { valor = 7.00; } break;
                    case "4": { valor = 8.00; } break;
                    case "5": { valor = continha.Saldo; } break;
                }

                if (continha.Comprar(valor))
                    Console.WriteLine("Compra efetuada com sucesso!");
                else
                    Console.WriteLine("Infelizmente seu saldo não é suficiente para este lanchinho.");

                Console.WriteLine($"Saldo atual disponível: R${continha.Saldo},00 de R$20,00");
                Console.ReadKey();
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Lanches disponíveis:" +
                                 "\r\n1 - Mini Pizza R$ 5,00" +
                                 "\r\n2 - Pão de Queijo R$ 2,00" +
                                 "\r\n3 - Pão de Batata R$ 7,00" +
                                 "\r\n4 - Pão com Bolinho R$ 8,00" +
                                 "\r\nEscolha a opção informando um número:");
        }
    }
}
