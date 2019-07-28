using AtividadeAnimalClass.FirstClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrandoAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cute = new Animal();

            Console.WriteLine("Seu bichinho:");

            Console.WriteLine($"\r\nEspécie: {cute.Pet} \r\n");

            Console.WriteLine($"{cute.WakeUp()}\r\n");

            Console.WriteLine($"{cute.Eat()}\r\n");

            Console.WriteLine($"{cute.Sleep()}\r\n");

            Console.ReadKey();


            Rotina today = new Rotina();

            Console.WriteLine("\r\nA rotina do seu bichinho:");

            Console.WriteLine($"\r\nEspécie: {today.Pet} \r\n");

            Console.WriteLine($"Idade: {today.Age} ano \r\n");

            Console.WriteLine($"{today.WakeUp()}\r\n");

            Console.WriteLine($"{today.Eat()}\r\n");

            Console.WriteLine($"{today.Sleep()}\r\n");

            Console.ReadKey();
        }
    }
}
