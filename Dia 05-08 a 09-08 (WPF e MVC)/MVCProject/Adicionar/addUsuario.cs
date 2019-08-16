using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Adicionar
{
    public partial class addUsuario : Form
    {
        public addUsuario()
        {
            InitializeComponent();
        }

        public Usuario usuarioRow;

        private void TbxEmail_TextChanged(object sender, EventArgs e)
        {
            //if (!this.tbxEmail.Text.Contains('@') || !this.tbxEmail.Text.Contains('.'))
            //{
            //    MessageBox.Show("Favor digitar um Email válido", "Email inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            usuarioRow = new Usuario
            {
                Nome = tbxNome.Text,
                Login = tbxLogin.Text,
                Senha = tbxSenha.Text,
                Email = tbxEmail.Text
            };
            this.Close();
        }

        private void AddUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
