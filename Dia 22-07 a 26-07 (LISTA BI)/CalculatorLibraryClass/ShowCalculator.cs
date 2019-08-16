using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibraryClass
{
    public class ShowCalculator
    {
        public double CalculatorAdicao(double x, double y)
        {
            return x + y;
        }
        public double CalculatorSubtracao(double x, double y)
        {
            return x - y;
        }
        public double CalculatorMultiplicacao(double x, double y)
        {
            return x * y;
        }
        public double CalculatorDivisao(double x, double y)
        {
            return x / y;
        }
        public double CalculatorRectangle(double alturaH, double baseB)
        {
            return baseB * alturaH;
        }
        public double CalculatorTriangle(double alturaH, double baseB)
        {
            return ((baseB * alturaH) / 2);
            //return ((baseB * alturaH * Math.Sqrt(3)) / 4);
        }
        public double CalculatorCircle(double circuloC)
        {
            return (Math.Sqrt(circuloC / Math.PI));
        }
    }
}
