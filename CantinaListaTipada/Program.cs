using CantinaListaTipada.LanchesDaCantina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                    //Inicializei minha lista aqui:
            List<Lanches> listaAdd = new List<Lanches>();

            for (int i = 0; i < 2; i++)
            {
                listaAdd.Add(new Lanches()
                {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                }); 
               
            }

            foreach (Lanches item in listaAdd)
            {
                Console.WriteLine($"Nome: {item.Nome} Quantidade: {item.Quantidade} Valor: {item.Valor}");
            }
            Console.ReadKey();
        }

        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }
    }
}
