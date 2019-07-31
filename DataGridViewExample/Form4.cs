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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0: //Coluna deletar
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    }
                    break;
            }

            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Vendas);

        }
    }
}
