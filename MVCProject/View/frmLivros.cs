using MVCProject.Adicionar;
using MVCProject.Editar;
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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addLivro livroAdd = new addLivro();
            livroAdd.ShowDialog();


            //if (!string.IsNullOrEmpty(livroAdd.livroRow?.Registro.ToString()))
            if (livroAdd.livroRow?.Registro > 0)
            {
                this.livrosTableAdapter.Insert(
                                    livroAdd.livroRow.Registro,
                                    livroAdd.livroRow.Titulo,
                                    livroAdd.livroRow.ISBN,
                                    livroAdd.livroRow.Genero,
                                    livroAdd.livroRow.Editora,
                                    livroAdd.livroRow.Sinopse,
                                    livroAdd.livroRow.Observacoes,
                                    true,
                                    1,
                                    1,
                                    DateTime.Now,
                                    DateTime.Now);
            }
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:                             //Coluna deletar
                    {
                        this.livrosTableAdapter.DeleteQuery(livroSelect.Id);
                    }
                    break;
                case 1:
                    {
                        editLivro livroEdit = new editLivro();
                        livroEdit.livrosRow = livroSelect;
                        //autorEdit.autoresRow = autorSelect;
                        livroEdit.ShowDialog();
                

                        this.livrosTableAdapter.Update(livroEdit.livrosRow);
                    }
                    break;
            }           

            this.livrosTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Livros);
        }
    }
}
