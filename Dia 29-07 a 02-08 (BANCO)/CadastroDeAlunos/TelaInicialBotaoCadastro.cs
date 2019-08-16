using CadastroDeAlunos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAlunos
{
    public partial class TelaInicialBotaoCadastro : Form
    {
        public TelaInicialBotaoCadastro()
        {
            InitializeComponent();
        }

        public List<Aluno> aluno = new List<Aluno>();

        private void TbxCadastro_Click(object sender, EventArgs e)
        {
            TelaDeCadastro formCad = new TelaDeCadastro();
            formCad.ShowDialog();
            aluno.Add(formCad.alunoCadastro);
        }
    }
}
