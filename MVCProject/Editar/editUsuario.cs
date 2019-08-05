using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Editar
{
    public partial class editUsuario : Form
    {
        public editUsuario()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow usuariosRow;


        private void TbxEmail_TextChanged(object sender, EventArgs e)
        {
            //    if (!this.tbxEmail.Text.Contains('@') || !this.tbxEmail.Text.Contains('.'))
            //    {
            //        MessageBox.Show("Favor digitar um Email válido", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void EditUsuario_Load(object sender, EventArgs e)
        {
            tbxNome.Text = usuariosRow.Nome;
            tbxLogin.Text = usuariosRow.Login;
            tbxSenha.Text = usuariosRow.Senha;
            tbxEmail.Text = usuariosRow.Email;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            usuariosRow.Nome = tbxNome.Text;
            usuariosRow.Login = tbxLogin.Text;
            usuariosRow.Senha = tbxSenha.Text;
            usuariosRow.Email = tbxEmail.Text;

            this.Close();
        }
    }
}
