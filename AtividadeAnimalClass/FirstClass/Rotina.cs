using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAnimalClass.FirstClass
{
    public class Rotina
    {
        public string Pet { get; set; } = "Canina";
        public int Age { get; set; } = 1;
        
        public string WakeUp()
        {
            return "Acordando";
        }
        public string Eat()
        {
            return "Comendo";
        }
        public string Sleep()
        {
            return "Dormindo";
        }
    }
}
