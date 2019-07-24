using CalculatorLibrary.CreatingCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUsingCalculatorLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator bbCalc = new Calculator();

            Console.WriteLine("Calculando operações básicas:");
            Console.WriteLine($"\r\nAdição:\r\n5 + 5 = {bbCalc.CalculatorAdicao(5, 5)}");
            Console.WriteLine($"\r\nSubtração:\r\n5 - 5 = {bbCalc.CalculatorSubtracao(5, 5)}");
            Console.WriteLine($"\r\nMultiplicação:\r\n5 * 5 = {bbCalc.CalculatorMultiplicacao(5, 5)}");
            Console.WriteLine($"\r\nDivisão:\r\n5 / 5 = {bbCalc.CalculatorDivisao(5, 5)}");

            Console.ReadKey();
        }
    }
}
