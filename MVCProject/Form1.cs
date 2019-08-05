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
    public partial class Form1 : Form   //Form é a herança, uma biblioteca com inumeras opções
    {
        public Form1()
        {
            InitializeComponent();

            //new Livro().
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmPrincipal menu = new frmPrincipal();
            menu.ShowDialog();
        }
    }
}
