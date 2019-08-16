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

namespace WpfCalculadora
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

        private void LoginForm_Loaded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            //LoginForm.Visibility = Visibility.Hidden;
            //CalculadoraForm.Visibility = Visibility.Visible;

        }

        private void LoginForm_loginCorrect(object sender, EventArgs e)     //chama a calculadora após o login
        {
            CalculadoraForm.Visibility = Visibility.Visible;
            //MessageBox.Show(sender.ToString());     //recebo a informação
        }
    }
}
