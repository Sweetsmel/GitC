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
    public partial class addLocacao : Form
    {
        public addLocacao()
        {
            InitializeComponent();
        }
        public Locacao locacaoRow;
        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            locacaoRow = new Locacao
            {
                Livro = (int)cbLivro.SelectedValue,
                Usuario = (int)cbUsuario.SelectedValue,
                Tipo = (int)nrTipo.Value,
                Devolucao = DateTime.Now,
                DiasAloc = (int)nrDiasAloc.Value
            };

            this.Close();
        }

        private void AddLocacao_Load(object sender, EventArgs e)
        {
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }
    }
}
