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
    public partial class editAutor : Form
    {
        public editAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow autoresRow;

        private void EditAutor_Load(object sender, EventArgs e)
        {
            tbxNome.Text = autoresRow.Nome;
            tbxDescricao.Text = autoresRow.Descrição;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            autoresRow.Nome = tbxNome.Text;
            autoresRow.Descrição = tbxDescricao.Text;

            this.Close();

        }

    }
}
