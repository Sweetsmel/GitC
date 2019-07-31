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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }
        private void FrmVendas_Click(object sender, EventArgs e)
        {
            Form4 frmVendas = new Form4();
            frmVendas.ShowDialog();
        }
        private void FrmUsuarios_Click(object sender, EventArgs e)
        {
            Form3 frmUsuarios = new Form3();
            frmUsuarios.ShowDialog();
        }
        private void FrmAdicionar_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)                              //foi isolado pois são objetos diferentes "( )"
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.QuerysInnerJoinDataSet1.CarrosRow;               //*DataGridViewExample = nome do namespace           
            //Este código ta convertendo toda a linha selecionada para uma

            switch(e.ColumnIndex)
            {   
                case 0: //Coluna deletar
                    {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                    } break;
            }

            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Lixeira frmlixeira = new Lixeira();
            frmlixeira.ShowDialog();
        }

    }
}
