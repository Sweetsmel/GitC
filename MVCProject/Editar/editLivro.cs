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
    public partial class editLivro : Form
    {
        public editLivro()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow livrosRow;

        private void EditLivro_Load(object sender, EventArgs e)
        {
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

            nrRegistro.Value = livrosRow.Registro;
            tbxTitulo.Text = livrosRow.Titulo;
            tbxIsbn.Text = livrosRow.Isbn;
            cbGenero.SelectedValue = livrosRow.Genero;
            cbEditora.SelectedValue = livrosRow.Editora;
            tbxSinopse.Text = livrosRow.Sinopse;
            tbxObs.Text = livrosRow.Obervacoes;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            livrosRow.Registro = (int)nrRegistro.Value;
            livrosRow.Titulo = tbxTitulo.Text;
            livrosRow.Isbn = tbxIsbn.Text;
            livrosRow.Genero = (int)cbGenero.SelectedValue;
            livrosRow.Editora = (int)cbEditora.SelectedValue;
            livrosRow.Sinopse = tbxSinopse.Text;
            livrosRow.Obervacoes = tbxObs.Text;

            this.Close();
        }
    }
}
