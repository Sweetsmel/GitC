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
    public partial class addEditora : Form
    {
        public addEditora()
        {
            InitializeComponent();
        }
        public Editora editoraRow;
        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            editoraRow = new Editora
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text
            };

            this.Close();
        }
    }
}
