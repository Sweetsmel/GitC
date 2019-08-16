using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }

        public Carro carrosRow;

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Carro
            {

                Modelo = tbwModelAdd.Text,
                Ano = dtYearAdd.Value,
                Marca = (int)cbMarcAdd.SelectedValue
        };
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
