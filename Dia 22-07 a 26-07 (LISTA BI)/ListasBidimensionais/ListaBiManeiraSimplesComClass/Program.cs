using ListaBiManeiraSimplesComClass.Carrega;
using ListaBiManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var carregaLista = new CarregarLista();                            //iniciando nosso objeto em memória

            carregaLista.CarregaInformacoesEListaElasEmTela();                 //chamamos nosso método para carregar a lista

            var mostrarLista = new MostrarLista();                             //carregamos novamente, mas agr a classe "mostrar lista", onde colocamos todos os métodos q serão direcionados para mostrar a listagem de informações na tela do console

            mostrarLista.PesquisandoInformacoesNaNossaLista(carregaLista.ListaNome,"0");  //chamamos o método novamente com (nome string e "id")

            Console.ReadKey();
        }
    }
}
