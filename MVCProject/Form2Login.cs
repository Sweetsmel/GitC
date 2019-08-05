using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class Form2Login : Form
    {
        public Form2Login()
        {
            InitializeComponent();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
            var result = this.usuariosTableAdapter1.LoginQuery(textBox1.Text, textBox2.Text);

            if (result != null)
            {
                Session.user = new Usuario();
                Session.user.Id = (int)result;

                frmPrincipal frm = new frmPrincipal();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login inválido!");
            }
        }
    }
}
