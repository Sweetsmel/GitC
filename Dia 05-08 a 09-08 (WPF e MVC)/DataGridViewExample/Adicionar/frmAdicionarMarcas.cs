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
    public partial class frmAdicionarMarcas : Form
    {
        public frmAdicionarMarcas()
        {
            InitializeComponent();
        }

        public Marcas marcasRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            marcasRow = new Marcas
            {

                Nome = tbxNameAdd.Text,

            };
            this.Close();
        }

        private void FrmAdicionarMarcas_Load(object sender, EventArgs e)
        {
            //this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);
        }

        private void TbxNameAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
