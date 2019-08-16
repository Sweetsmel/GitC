using CadastroDeLanches.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeLanches
{
    public partial class TelaInicioEMostraCadastros : Form
    {
        public TelaInicioEMostraCadastros()
        {
            InitializeComponent();
        }

        public List<Lanche> lanches = new List<Lanche>();       //lista assinada.

        private void Button1_Click(object sender, EventArgs e)
        {
            TelaDeCadastro formCad = new TelaDeCadastro();
            formCad.ShowDialog();
            lanches.Add(formCad.novoLanche);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lanches;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaInicioEMostraCadastros_Load(object sender, EventArgs e)
        {

        }
    }
}
