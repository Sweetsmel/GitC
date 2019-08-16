using MVCProject.Adicionar;
using MVCProject.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuariosSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:                             //Coluna deletar
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuariosSelect.Id);
                    }
                    break;
                case 1:
                    {
                        editUsuario usuarioEdit = new editUsuario();
                        usuarioEdit.usuariosRow = usuariosSelect;
                        usuarioEdit.ShowDialog();


                        this.usuariosTableAdapter.Update(usuarioEdit.usuariosRow);
                    }
                    break;

            }

            this.usuariosTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addUsuario usuarioAdd = new addUsuario();
            usuarioAdd.ShowDialog();

            if (!string.IsNullOrEmpty(usuarioAdd.usuarioRow?.Nome))

                this.usuariosTableAdapter.Insert(
                                        usuarioAdd.usuarioRow.Nome,
                                        usuarioAdd.usuarioRow.Login,
                                        usuarioAdd.usuarioRow.Senha,
                                        usuarioAdd.usuarioRow.Email,
                                        true,
                                        1,
                                        1,
                                        DateTime.Now,
                                        DateTime.Now
            );
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
