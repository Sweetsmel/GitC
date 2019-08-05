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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addAutor autorAdd = new addAutor();
            autorAdd.ShowDialog();

            if (!string.IsNullOrEmpty(autorAdd.autorRow?.Nome))

                this.autoresTableAdapter.Insert(
                                        autorAdd.autorRow.Nome,
                                        autorAdd.autorRow.Descricao
            );
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                case 0:                             //Coluna deletar
                    {
                        this.autoresTableAdapter.DeleteQuery(autorSelect.Id);
                    }
                    break;
                case 1:
                    {
                        editAutor autorEdit = new editAutor();
                        autorEdit.autoresRow = autorSelect;
                        //autorEdit.autoresRow = autorSelect;
                        autorEdit.ShowDialog();


                        this.autoresTableAdapter.Update(autorEdit.autoresRow);
                    }
                    break;
            }

            this.autoresTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
