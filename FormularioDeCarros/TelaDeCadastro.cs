using FormularioDeCarros.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeCarros
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Carros novoCarro = new Carros();

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = tbxModelo.Text; 
            novoCarro.Ano = (int)nrAno.Value;
            novoCarro.Placa = tbxPlaca.Text;

            this.Close();
        }
    }
}
