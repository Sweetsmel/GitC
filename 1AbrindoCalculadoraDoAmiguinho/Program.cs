using CalculadoraCompleta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1AbrindoCalculadoraDoAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora bbCalc = new Calculadora();

            //bbCalc.Adicao(5,5);

            Console.WriteLine("Calculando operações básicas:");
            Console.WriteLine($"\r\nAdição:\r\n5 + 5 = {bbCalc.Adicao(5, 5)}");
            Console.WriteLine($"\r\nSubtração:\r\n5 - 5 = {bbCalc.Subtracao(5, 5)}");
            Console.WriteLine($"\r\nMultiplicação:\r\n5 * 5 = {bbCalc.Multiplicacao(5, 5)}");
            Console.WriteLine($"\r\nDivisão:\r\n5 / 5 = {bbCalc.Divisao(5, 5)}");

            Console.WriteLine($"\r\nArea de um Retangulo:\r\n5 * 5 = {bbCalc.AreaRetangulo(5, 5)}cm²");
            Console.WriteLine($"\r\nArea de um Triângulo Equilátero:\r\n5 * 5 / 2 = {bbCalc.AreaTrianguloEquilatero(5, 5)}");
            Console.WriteLine($"\r\nRaio a partir da área de um Círculo:\r\n {bbCalc.RaioCirculo(5)}cm");

            Console.ReadKey();
        }
    }
}
