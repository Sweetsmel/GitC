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
    public partial class editEditora : Form
    {
        public editEditora()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow editorasRow;

        private void EditEditora_Load(object sender, EventArgs e)
        {
            tbxNome.Text = editorasRow.Nome;
            tbxDescricao.Text = editorasRow.Descrição;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            editorasRow.Nome = tbxNome.Text;
            editorasRow.Descrição = tbxDescricao.Text;

            this.Close();
        }
    }
}
