using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFCadastro.View
{
    /// <summary>
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class Cadastro : UserControl
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public event EventHandler cadastroCorrect;

        private void BtSalvar_Click(object sender, RoutedEventArgs e)
        {
            var email = tbxEmail.Text;
            var numero = tbxEmail.Text;


            if (ValidatesCustom.ValidEmail(email))
            {
                MessageBox.Show("E-mail correto!");
            }
            else
            {
                MessageBox.Show("E-mail incorreto!");
            }

            if (ValidatesCustom.ValidNumero(numero))
            {
                MessageBox.Show("Número correto!");
            }
            else
            {
                MessageBox.Show("Número incorreto!");
            }
        }
        public void Teste(string pais, string estado)
        {
            if (pais == "Brasil" && estado == "SC")
            {
                this.Visibility = Visibility.Hidden;
                cadastroCorrect(null, new EventArgs());
            }
            else
                MessageBox.Show("Cadastro inválido!");
        }
    }
}
