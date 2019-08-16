using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Carrega
{
    class CarregarLista
    {
        string[,] listaDeNome;                        //lista privada pela string, não tem "public"
        
        /// <summary>
        /// Retorna a lista de nome apenas como leitura
        /// </summary>
        public string[,] ListaNome { get { return listaDeNome; } }


        /// <summary>
        /// Nosso método construtor que sempre recebe o nome da Classe (class CarregarLista)
        /// </summary>
        /// <param name="arrayBi">Array q j´´a deve estar assinada</param>
        public CarregarLista()
        {
            listaDeNome = new string[10, 2];          //assinamos nossa lista, com isso já deixamos a lista pronta para uso nos demais métodos sem precisar de um parametro para isso

        }
        
        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN" e mostra as informações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        public void CarregaInformacoesEListaElasEmTela()
        {

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {

                listaDeNome[i, 0] = i.ToString();

                listaDeNome[i, 1] = $"Sabrina_{i}";
            }

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {

                Console.WriteLine($"ID: {listaDeNome[i, 0]} - Nome: {listaDeNome[i, 1]}");
            }

        }
    }
}
