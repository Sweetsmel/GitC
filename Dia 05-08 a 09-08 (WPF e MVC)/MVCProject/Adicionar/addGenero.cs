using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Adicionar
{
    public partial class addGenero : Form
    {
        public addGenero()
        {
            InitializeComponent();
        }

        public Genero generoRow;

        private void AddGenero_Load(object sender, EventArgs e)
        {

        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            generoRow = new Genero
            {
                Tipo = tbxTipo.Text,
                Descricao = tbxDescricao.Text

            };
            this.Close();
        }
    }
}
