using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {
        /// <summary>
        /// sexta hoje?
        /// </summary>
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui iniciamos o nosso joinha.");

            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eQuinta"></param>
        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta)
            {
                Console.WriteLine("Carai Mermão!!");
            }
            else
            {
                Console.WriteLine("Aiaiaiiai!!");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Método que vamos identificar o tipo
        /// </summary>
        /// <returns></returns>
        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste 1", "Teste 2" };

        }
    }
}
