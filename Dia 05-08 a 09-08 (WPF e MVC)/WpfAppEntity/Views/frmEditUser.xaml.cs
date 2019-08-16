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
using System.Windows.Shapes;
using WpfAppEntity.Data;

namespace WpfAppEntity.Views
{
    /// <summary>
    /// Interaction logic for frmEditUser.xaml
    /// </summary>
    public partial class frmEditUser : Window
    {
        public frmEditUser()
        {
            InitializeComponent();
        }
        public Usuario user;

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            user.Nome =  tbxUsuario.Text;
            user.Login = tbxLogin.Text;
            user.Senha = tbxSenha.Text;

            this.DialogResult = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbxUsuario.Text = user.Nome;
            tbxLogin.Text = user.Login;
            tbxSenha.Text = user.Senha;
        }
    }
}
