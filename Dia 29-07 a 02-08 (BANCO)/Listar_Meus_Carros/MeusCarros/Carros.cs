using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_Meus_Carros.MeusCarros
{
    public class Carros
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Placa { get; set; }
        public int Cv { get; set; }

        public static string MenuInicial()
        {
            Console.Clear();

            Console.WriteLine("\r\n             MENU - Listando Carros");
            Console.WriteLine("\r\n             O que você deseja realizar?");
            Console.WriteLine("\r\n             1 - Inserir um novo veículo");
            Console.WriteLine("             2 - Remover um veículo");
            Console.WriteLine("             3 - Listar os carros");
            //Console.WriteLine("             4 - Alterar Registros.");
            Console.WriteLine("             4 - Sair do Sistema");
            Console.WriteLine("\r\n-----------------------------------------------------------");
            Console.WriteLine("\r\n          Digite o número da opção desejada:");
            return Console.ReadLine();
        }
        public void AdicionaCarros()
        {
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\r\n                   ADICIONANDO CARROS");
            Console.WriteLine("\r\n-----------------------------------------------------------");

            var listaAdd = new List<Carros>();

            for (int i = 0; i < 2; i++)
            {
                listaAdd.Add(new Carros()
                {
                    Modelo = RetornaValores("Modelo"),
                    Ano = int.Parse(RetornaValores("Ano")),
                    Placa = double.Parse(RetornaValores("Placa")),
                    Cv = int.Parse(RetornaValores("Cv"))
                });
            }
                Console.ReadKey();
        }
        public void ListarCarros()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\r\n          APRESENTAÇÃO DOS REGISTROS DE CARROS");
            Console.WriteLine("\r\n-----------------------------------------------------------");

            var listaAdd = new List<Carros>();

            foreach (Carros item in listaAdd)
            {
                Console.WriteLine($"Modelo: {item.Modelo}",
                                  $"Ano: {item.Ano}",
                                  $"Placa: {item.Placa}",
                                  $"Cv: {item.Cv}");
            }
            Console.ReadKey();
        }
        public string RetornaValores(string valor)
        {
            Console.WriteLine($"Informe o valor para o campo: {valor}");
            return Console.ReadLine();
        }

        #region nao sei se vai
        /*
        public static string RetornaModelo(string modelo)
        {
            Console.WriteLine($"Informe o modelo do carro para o campo: {modelo}");
            return Console.ReadLine();
        }
        public static int RetornaAno(int ano)
        {
            Console.WriteLine($"Informe o ano do carro para o campo: {ano}");
            return Console.ReadLine();
        }
        public static string RetornaPlaca(string placa)
        {
            Console.WriteLine($"Informe a placa do carro para o campo: {placa}");
            return Console.ReadLine();
        }
        public static int RetornaPotenciaCavalos(int Cv)
        {
            Console.WriteLine($"Informe a potência do carro para o campo: {Cv}");
            return Console.ReadLine();
        }
        */
        #endregion

    }
}
