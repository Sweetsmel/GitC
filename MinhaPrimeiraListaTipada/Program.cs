using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
                                                            //O indicador <T> o tipo da minha lista, com isso temos uma lista de lanches.
            List<Lanche> minhalista = new List<Lanche>();


            minhalista.Add(new Lanche()                     //Adiciono na minha lista um pão de queijo.
            {
                Nome = "Pão de Queijo.",
                Quantidade = 9,
                Valor = 1.85
            });
            minhalista.Add(new Lanche()                     //Adiciono na minha lista um pão com bolinho.
            {
                Nome = "Pão com Bolinho + Refri. Bonus: Sobremesa.",
                Quantidade = 2,
                Valor = 7.50
            });
                                                            //Aqui ando pela minha lista para poder apresentar em tela os valores.
            foreach (Lanche item in minhalista)             //"item in" significa q ele já é um índice da minha lista bonitinho.
            {//não precisa da abertura e fechamento
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");
            }
            Console.WriteLine("Removendo Item.");

            foreach (Lanche item in minhalista)
            {
                if (item.Quantidade == 3)
                {
                    minhalista.Remove(item);
                    break;
                }
            }
            foreach (Lanche item in minhalista)
            {
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");
            }
            Console.ReadKey();
        }
    }
}
