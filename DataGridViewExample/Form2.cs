using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.QuerysInnerJoinDataSet1.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0: //Coluna deletar
                    {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    }
                    break;
                case 1: //Editar
                    {
                        frmEdicaoMarcas editMarc = new frmEdicaoMarcas();
                        editMarc.MarcasRow = marcasSelect;
                        editMarc.ShowDialog();

                        this.marcasTableAdapter.Update(editMarc.MarcasRow);

                    }
                    break;
            }

            this.marcasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Marcas);

        }
    }
}
