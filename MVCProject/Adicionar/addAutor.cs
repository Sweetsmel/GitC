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
    public partial class addAutor : Form
    {
        public addAutor()
        {
            InitializeComponent();
        }

        public Autor autorRow;

        private void AddAutor_Load(object sender, EventArgs e)
        {

        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            autorRow = new Autor
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text
            };
            this.Close();
        }
    }
}
