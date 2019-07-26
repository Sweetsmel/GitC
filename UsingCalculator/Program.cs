using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibraryClass;

namespace UsingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var outro = new ShowCalculator().CalculatorAdicao();

            ShowCalculator bbCalc = new ShowCalculator();

            Console.WriteLine("Calculando operações básicas:");
            Console.WriteLine($"\r\nAdição:\r\n5 + 5 = {bbCalc.CalculatorAdicao(5, 5)}");
            Console.WriteLine($"\r\nSubtração:\r\n5 - 5 = {bbCalc.CalculatorSubtracao(5, 5)}");
            Console.WriteLine($"\r\nMultiplicação:\r\n5 * 5 = {bbCalc.CalculatorMultiplicacao(5, 5)}");
            Console.WriteLine($"\r\nDivisão:\r\n5 / 5 = {bbCalc.CalculatorDivisao(5, 5)}");

            Console.WriteLine($"\r\nArea de um Retangulo:\r\n5 * 5 = {bbCalc.CalculatorRectangle(5, 5)}cm²");
            Console.WriteLine($"\r\nArea de um Triângulo Equilátero:\r\n5 * 5 / 2 = {bbCalc.CalculatorTriangle(5, 5)}");
            Console.WriteLine($"\r\nRaio a partir da área de um Círculo:\r\n {bbCalc.CalculatorCircle(5)}cm");

            Console.ReadKey();

        }
    }
}
