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
    public partial class TelaParaCadastro : Form
    {
        public TelaParaCadastro()
        {
            InitializeComponent();
        }

        public List<Carros> carros = new List<Carros>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TelaDeCadastro formCad = new TelaDeCadastro();
            formCad.ShowDialog();
            carros.Add(formCad.novoCarro);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = carros;
        }
    }
}
