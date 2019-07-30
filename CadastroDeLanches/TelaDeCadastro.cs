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
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Lanche novoLanche = new Lanche();        //ASSINADA

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            novoLanche.Nome = tbxNome.Text;             //text é a propriedade publica 
            novoLanche.Quantidade = (int)nrQuant.Value; //"(int)" cria uma conversão explicida, pois retornará um numero
            novoLanche.Valor = double.Parse(tbxValor.Text); //Parse só converte de texto para numeros

            this.Close();
        }
    }
}
