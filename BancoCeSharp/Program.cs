using BancoCeSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Informe o valor para saque:");       

            double.TryParse(Console.ReadLine(), out double valorSacar);                 //Aqui usamos a conversão do valor informado.

            //Não é necessário as aberturas
            if (valorSacar > 0 && accountUser.Sacar(valorSacar))                        //Verificamos se o valor é maior q 0 e se realizou o saque.
                Console.WriteLine("Saque realizado com sucesso!");
            else
                Console.WriteLine("Operação não realizada.");
            
            Console.WriteLine($"Saldo atual disponível: {accountUser.Saldo.ToString("N2")}"); //Mostramos o saldo disponível.

            Console.ReadKey();
        }
    }
}
