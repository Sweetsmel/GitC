using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new Teste(5,5);      //informou o construtor (int, int) a tabela

            elementoX.MostrarInformacoes();

            elementoX.AlteraInformacoes(5,5);

            elementoX.MostrarInformacoes();

            MeninasSuperPoderosas(elementoX);   //nem precisa disso
            //elementoX.AlteraInformacoes();    //se por isso

            elementoX.MostrarInformacoes();

            Console.ReadKey();
        }

        public static void MeninasSuperPoderosas(Teste pTeste)    //Deu a mesma coisa
        {
            pTeste.AlteraInformacoes();
            pTeste.AlteraInformacoes();

        }
    }

    public class Teste
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0;
        public Teste(int pA,int pB)
        {
            A = pA;
            B = pB;
        }

        public void AlteraInformacoes()     //Sobrecarregar, puxar novamente o mesmo 
        {
            A = B * 100;
        }

        public void AlteraInformacoes(int pA, int pB)
        {
            A = pA * 2;
            B = pB * 2;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(A + B);
        }

    }
}
