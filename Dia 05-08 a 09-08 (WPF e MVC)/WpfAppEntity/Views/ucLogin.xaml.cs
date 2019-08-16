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
using WpfAppEntity.Data;

namespace WpfAppEntity.Views
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        public event EventHandler sucess;
        public event EventHandler fail;
        public BibliotecaDBContext context = new BibliotecaDBContext(); //já assinada para economizar tempo, quando abre já está carregando

        private void ButtonEntrar_Click(object sender, RoutedEventArgs e)
        {
            var userName = tbxLogin.Text;
            var userPass = passSenha.Password;

            var result = context.Usuarios                                   
                .FirstOrDefault(x =>                                        //First primeiro ou nulo
                x.Login == userName 
                && x.Senha == userPass);
                                                                            //ao clicar vai dar sucesso ou falho
            if (result?.Id > 0)                                             //converteu um objeto usuario
                sucess("Usuário logado com sucesso!", new EventArgs());
            else
                fail($"Falha ao logal com usuário {userName}.", new EventArgs());   
            
        }
    }
}
