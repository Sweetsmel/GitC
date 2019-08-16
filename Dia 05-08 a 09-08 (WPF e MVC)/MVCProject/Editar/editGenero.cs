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
    public partial class editGenero : Form
    {
        public editGenero()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow generosRow;

        private void EditGenero_Load(object sender, EventArgs e)
        {
            tbxTipo.Text = generosRow.Tipo;
            tbxDescricao.Text = generosRow.Descrição;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            generosRow.Tipo = tbxTipo.Text;
            generosRow.Descrição = tbxDescricao.Text;

            this.Close();
        }
    }
}
