using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFAppNew.Data;

namespace WPFAppNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public BibliotecaDBContext context;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context = new BibliotecaDBContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*MessageBox.Show(context.Usuarios.FirstOrDefault(x => x.Id > 0).Nome);       //vai trazer o primeiro usuario do banco de dados
            MessageBox.Show(context.Usuarios
                .OrderByDescending(x => x.Id)
                .FirstOrDefault(x => x.Nome == "Loco").Id.ToString());                    //traz o Id do nome*/

            MessageBox.Show(context.Usuarios
                                   .OrderBy(x => x.Nome)
                                   .FirstOrDefault(x => x.Id > 0).Nome);

            var runList = context.Usuarios
                                 .OrderBy(x => x.Nome)
                                 .ToList<Usuario>();                                      //vai retornar uma lista genérica, pois orderBy não sabe o q deve retornar

            gridView1.ItemsSource = runList;                                              //antes de runList era: context.Usuarios.OrderBy(x => x.Nome)
        }
    }
}
