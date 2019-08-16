using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    public class Conta    //ENCAPSULAMENTO
    {
        double saldo = 0;
        //deixa publico para alterar em qualquer lugar. Get já cria o retorno do proprio valor. Set é um valor específico que vc dará.
        public double Saldo { get { return saldo; } }                              //Propriedade q contém o valor do saldo.

        public Conta()
        {
            saldo = 1000;                                                          //Bonus de mil reais para iniciar operação daytrade.
        }
        /// <summary>
        /// Método para sacar de acordo com o saldo disponível.
        /// </summary>
        /// <param name="valor">Valor para sacar.</param>
        /// <returns>Retorna se o saque foi feito ou não.</returns>
        public bool Sacar(double valor)
        {
            if(valor <= saldo)
            {   
                saldo -= valor;                                                         //Desconta do valor em saldo na conta.
                return true;
            }
            
            return false;                                                               //Retorna false em caso de não conter saldo.
        }
        /// <summary>
        /// Método q mostra o saldo em conta disponível.
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
