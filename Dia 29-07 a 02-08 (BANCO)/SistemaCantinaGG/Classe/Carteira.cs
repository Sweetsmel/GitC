using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG.Classe
{
    public class Carteira
    {
        double saldo = 0;

        public string Aluno { get; set; } = "Sabrina";
        public double Saldo { get { return saldo; } } //não é metodo   

        public Carteira(double valor)    //valor q o aluno tem na carteira
        {
            saldo = valor;
        }
        public bool Comprar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
