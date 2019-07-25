using CriacaoBoletimEscolar.BoletimEscolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizacaoBoletimEscolar
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaRegistros cad = new ListaRegistros();

            MostrarInicio();

            var escolhaInicial = MenuInicial();

            while (true)
            {
                switch (escolhaInicial)
                {
                    case "1": { cad.InserindoAlunoNomeNota(); } break;
                    case "2": { cad.RemoverRegistro(); } break;
                    case "3": { cad.ListarCadastros(); } break;
                    case "4": { cad.AlterarRegistro(); } break;
                    case "5": { return; }
                }
                escolhaInicial = MenuInicial();
            }
        }
        public static void MostrarInicio()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("             BEM VINDO AO SISTEMA DE ESCOLA!");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("             Desenvolvido pela indústria S.A");
            Console.WriteLine("-----------------------------------------------------------");
        }
        public static string MenuInicial()
        {
            Console.Clear();

            MostrarInicio();

            Console.WriteLine("\r\n             MENU - Registros de Alunos");
            Console.WriteLine("\r\n             O que você deseja realizar?");
            Console.WriteLine("\r\n             1 - Inserir um novo registro");
            Console.WriteLine("             2 - Remover um novo registro");
            Console.WriteLine("             3 - Listar informações");
            Console.WriteLine("             4 - Alterar Registros.");
            Console.WriteLine("             5 - Sair do Sistema");
            Console.WriteLine("\r\n-----------------------------------------------------------");
            Console.WriteLine("\r\n          Digite o número da opção desejada:");
            return Console.ReadLine();
        }
    }
}
