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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addGenero generoAdd = new addGenero();
            generoAdd.ShowDialog();

            if (!string.IsNullOrEmpty(generoAdd.generoRow?.Tipo))

                this.generosTableAdapter.Insert(
                                        generoAdd.generoRow.Tipo,
                                        generoAdd.generoRow.Descricao

            );
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var generoSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:                             //Coluna deletar
                    {
                        this.generosTableAdapter.DeleteQuery(generoSelect.Id);
                    }
                    break;
                case 1:
                    {
                        editGenero generoEdit = new editGenero();
                        generoEdit.generosRow = generoSelect;
                        //autorEdit.autoresRow = autorSelect;
                        generoEdit.ShowDialog();


                        this.generosTableAdapter.Update(generoEdit.generosRow);
                    }
                    break;
            }

            this.generosTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
