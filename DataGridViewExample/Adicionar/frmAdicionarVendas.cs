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
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }

        public Vendas vendasRow;

        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);      //vai puxar a tabela de carros.
            //this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(tbxValueAdd.Text, out decimal valor);      //criada a variavel para "Valor".

            vendasRow = new Vendas
            {
                Carro = (int)cbCarAdd.SelectedValue,
                Quantidade = (int)nrQuantAdd.Value,
                Valor =  valor                                          //antes era: decimal.Parse(tbxValueAdd.Text). Apenas criou uma variavel.
            };
            this.Close();
        }
    }
}
