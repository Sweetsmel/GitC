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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void Editoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addEditora editoraAdd = new addEditora();
            editoraAdd.ShowDialog();

            if (!string.IsNullOrEmpty(editoraAdd.editoraRow?.Nome))

                this.editorasTableAdapter.Insert(
                                        editoraAdd.editoraRow.Nome,
                                        editoraAdd.editoraRow.Descricao
            );
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var editoraSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;

            switch (e.ColumnIndex)
            {
                case 0:                             //Coluna deletar
                    {
                        this.editorasTableAdapter.DeleteQuery(editoraSelect.Id);
                    }
                    break;
                case 1:
                    {
                        editEditora editoraEdit = new editEditora();
                        editoraEdit.editorasRow = editoraSelect;
                        //autorEdit.autoresRow = autorSelect;
                        editoraEdit.ShowDialog();


                        this.editorasTableAdapter.Update(editoraEdit.editorasRow);
                    }
                    break;

            }

            this.editorasTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Editoras);
        }
    }
}
