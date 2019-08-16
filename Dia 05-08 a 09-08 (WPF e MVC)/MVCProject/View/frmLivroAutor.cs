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

namespace MVCProject.View
{
    public partial class frmLivroAutor : Form
    {
        public frmLivroAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow livrosRow;

        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.LivroAutor);

            label2.Text = livrosRow.Titulo;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.livroAutorTableAdapter.Insert(livrosRow.Id,
              (int)comboBox1.SelectedValue);

            this.livroAutorTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.LivroAutor, livrosRow.Id.ToString());
        }
    }
}
