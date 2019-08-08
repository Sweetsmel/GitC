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
using WPFCadastro.Controller;
using WPFCadastro.View;


namespace WPFCadastro
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

        private void CadastroXaml_cadastroCorrect(object sender, EventArgs e)
        {
            CadastroXaml.Visibility = Visibility.Visible;

        }

        private void CadastroXaml_cadastroCorrect_1(object sender, EventArgs e)
        {

        }
    }
}
