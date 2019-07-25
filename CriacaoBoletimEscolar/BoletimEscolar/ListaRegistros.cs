using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoBoletimEscolar.BoletimEscolar
{
    public class ListaRegistros
    {
        string[,] arrayAluno = new string[5, 6];
        NotasFrequencia boletim = new NotasFrequencia();
        int i = 0;

        public void InserindoAlunoNomeNota()   //inserir
        {
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\r\n               INSERINDO UM NOVO REGISTRO");
            Console.WriteLine("\r\n-----------------------------------------------------------");

            //pede o nome
            arrayAluno[i, 0] = i.ToString();

            Console.WriteLine("Informe o nome do Aluno:");
            var nome = Console.ReadLine();
            arrayAluno[i, 1] = nome;

            var media = digitaNotas();

            arrayAluno[i, 2] = media.ToString();


            //informações e frequencia
            Console.WriteLine("Informe o número de aulas:");
            int.TryParse(Console.ReadLine(), out int totalAulas);

            Console.WriteLine("Informe o número de faltas:");
            int.TryParse(Console.ReadLine(), out int numeroFaltas);

            var frequencia = boletim.RecebeFrequencia(totalAulas, numeroFaltas);
            arrayAluno[i, 3] = frequencia.ToString();

            //informa a situação
            arrayAluno[i, 4] = boletim.RetornaSituacao(media, frequencia);
            arrayAluno[i, 5] = "true";      //nem tinha


            //i = i + 1;
            //i += 1;
            i++;
            Console.Clear();


            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\r\nRegistro cadastrado com sucesso!");
            Console.WriteLine("\r\nPara voltar ao menu inicial, basta apertar qualquer tecla.");

            Console.ReadKey();
        }
        public int digitaNotas()
        {
            //dando as notas
            Console.WriteLine("Informe a primeira nota do Aluno:");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Informe a segunda nota do Aluno:");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Informe a terceira nota do Aluno:");
            int.TryParse(Console.ReadLine(), out int nota3);


            //calculando a media
            return boletim.RecebeNotas(nota1, nota2, nota3);
        }
        public void ListarCadastros()
        {
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\r\n                 APRESENTAÇÃO DOS REGISTROS");
            Console.WriteLine("\r\n-----------------------------------------------------------");

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine($"\r\nID {arrayAluno[i, 0]} " +
                                  $"> NOME DO ALUNO: {arrayAluno[i, 1]} " +
                                  $"- MEDIA: {arrayAluno[i, 2]} " +
                                  $"- FREQUÊNCIA: {arrayAluno[i, 3]}% " +
                                  $"- SITUAÇÃO: {arrayAluno[i, 4]}\n");
            }

            Console.WriteLine("\r\n-----------------------------------------------------------");
            Console.WriteLine("\r\nPara voltar ao menu inicial, favor informar qualquer tecla.");

            Console.ReadKey();
        }
        public void RemoverRegistro()
        {
            Console.Clear();

            Console.WriteLine("\r\n-----------------------------------------------------------");
            Console.WriteLine("\r\n               REMOÇÃO DE REGISTROS DO SISTEMA");
            Console.WriteLine("\r\n-----------------------------------------------------------");
            Console.WriteLine("\r\nInforme o ID do registro a ser removido:");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == id.ToString())
                {
                    arrayAluno[i, 1] = "";
                    arrayAluno[i, 2] = "";
                    arrayAluno[i, 3] = "";
                    arrayAluno[i, 4] = "";
                    break;
                }
            }

            Console.WriteLine("\r\n-----------------------------------------------------------");
            Console.WriteLine("\r\nOperações finalizadas com sucesso!");
            Console.WriteLine("\r\nPara retornar ao menu inicial, favor clicar em qualquer tecla.");

            Console.ReadKey();
        }
        public void AlterarRegistro()
        {
            Console.Clear();

            Console.WriteLine("\r\n-----------------------------------------------------------");
            Console.WriteLine("\r\n               ALTERAÇÃO DE REGISTROS DO SISTEMA");
            Console.WriteLine("\r\n-----------------------------------------------------------");
            Console.WriteLine("\r\nInforme o ID do registro a ser alterado:");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == id.ToString())
                {
                    var media = digitaNotas();

                    arrayAluno[i, 2] = media.ToString();  //media
                    var frequencias = Convert.ToInt32(arrayAluno[i, 3]);
                    arrayAluno[i, 4] = boletim.RetornaSituacao(media, frequencias);  //situação
                    break;
                }
            }
        }
    }
}
