using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstExternalLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var listas = new GetFiles();

            var listaDeArquivosDosMeusDocumentos = listas.RetornaArquivosDoMeuDocumentos();

            for (int i = 0; i < listaDeArquivosDosMeusDocumentos.Length; i++)
            {
                Console.WriteLine($"Documents: {listaDeArquivosDosMeusDocumentos[i]}");
            }

            Console.ReadKey();


            Console.Clear();

            var listaDeImagensDosMeusDocumentos = listas.RetornaArquivosImagesFiles();

            for (int i = 0; i < listaDeImagensDosMeusDocumentos.Length; i++)
            {
                Console.WriteLine($"Imagens: {listaDeImagensDosMeusDocumentos[i]}");
            }

            Console.ReadKey();


            Console.Clear();

            var listaDeArquivosGitDosMeusDocumentos = listas.RetornaArquivosGit();

            for (int i = 0; i < listaDeArquivosGitDosMeusDocumentos.Length; i++)
            {
                Console.WriteLine(listaDeArquivosGitDosMeusDocumentos[i]);
            }

            Console.ReadKey();
        }
    }
}
