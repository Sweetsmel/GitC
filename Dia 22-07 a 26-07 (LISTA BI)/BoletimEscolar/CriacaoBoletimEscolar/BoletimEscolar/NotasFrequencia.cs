using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoBoletimEscolar.BoletimEscolar
{
    public class NotasFrequencia
    {
        /// <summary>
        /// Faz a soma das notas
        /// </summary>
        /// <param name="nota1">Vai receber a primeira nota</param>
        /// <param name="nota2">Vai receber a segunda nota</param>
        /// <param name="nota3">Vai receber a terceira nota</param>
        /// <returns>Vai retornar a soma das notas dividia por 3</returns>
        public int RecebeNotas(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;     //faz o calculo para dar a media no fim
        }
        /// <summary>
        /// Faz a conta para a frequência.
        /// </summary>
        /// <param name="totalAulas">Vai receber/ler a quantidade de aulas</param>
        /// <param name="numeroFaltas">Vai receber/ler a quantidade de faltas</param>
        /// <returns></returns>
        public int RecebeFrequencia(int totalAulas, int numeroFaltas)
        {
            return ((totalAulas - numeroFaltas) * 100) / totalAulas;      //faz o calculo para dar a frequencia
        }
        public string RetornaSituacao(int media, int frequencia)    //texto
        {
            if ((media >= 7) && (frequencia >= 75))
            {
                return "Aprovado";
            }
            return "Reprovado";         //se nao retornar aprovado, retornara reprovado
        }

        /// <summary>
        /// Faz realizar as contas para trazer o resultado final.
        /// </summary>
        /// <param name="media">Vai pegar RecebeNotas</param>
        /// <param name="frequencia">Vai pegar RecebeFrequencia</param>
        public void Resultado(int media, int frequencia)
        {
            if((media >= 7) && (frequencia >= 75))
            {
                Console.WriteLine($"Aluno APROVADO com a média {media} e Frequência de {frequencia}%");
            }
            else
            {
                Console.WriteLine($"Aluno REPROVADO com a média {media} e Frequência de {frequencia}%");
            }
        }
    }
}
