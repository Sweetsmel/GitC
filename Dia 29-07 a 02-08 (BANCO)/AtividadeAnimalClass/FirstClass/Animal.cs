using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAnimalClass.FirstClass
{
    public class Animal
    {
        public string Pet { get; set; } = "Canina";

        public string WakeUp()
        {
            return "Acorda";
        }
        public string Eat()
        {
            return "Come";
        }
        public string Sleep()
        {
            return "Dorme";
        }
    }
}
