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
    public partial class addLivro : Form
    {
        public addLivro()
        {
            InitializeComponent();
        }

        public Livro livroRow;

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            //if (nrRegistro.Value < 1)
            //{
            //    MessageBox.Show("Informe registro");
            //    nrRegistro.Focus();
            //    return;
            //}

            livroRow = new Livro
            {
                Registro =   (int)nrRegistro.Value,
                Titulo =     tbxTitulo.Text,
                ISBN =       tbxIsbn.Text,
                Genero =     (int)cbGenero.SelectedValue,
                Editora =    (int)cbEditora.SelectedValue,
                Sinopse =    tbxSinopse.Text,
                Observacoes = tbxObs.Text
            };
            this.Close();
        }

        private void AddLivro_Load(object sender, EventArgs e)
        {
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }
    }
}
