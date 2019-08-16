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
    public partial class editLocacao : Form
    {
        public editLocacao()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow locacaoRow;

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            locacaoRow.Livro = (int)cbLivro.SelectedValue;
            locacaoRow.Usuario = (int)cbUsuario.SelectedValue;
            locacaoRow.Tipo = (int)nrTipo.Value;
            locacaoRow.Devolucao = dtDevolucao.Value;
            locacaoRow.DiasAloc = (int)nrDiasAloc.Value;

            this.Close();
        }

        private void EditLocacao_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);

            cbLivro.SelectedValue = locacaoRow.Livro;
            cbUsuario.SelectedValue = locacaoRow.Usuario;
            nrTipo.Value = locacaoRow.Tipo;
            dtDevolucao.Value = locacaoRow.Devolucao;
            nrDiasAloc.Value = locacaoRow.DiasAloc;

        }
    }
}
