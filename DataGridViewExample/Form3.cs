using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.QuerysInnerJoinDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0: //Coluna deletar
                    {
                        this.usuariosTableAdapter.DeleteQuery(userSelect.Id);
                    }
                    break;
                case 1: //Editar
                    {
                        frmEdicaoUsuarios editUsu = new frmEdicaoUsuarios();
                        editUsu.UsuariosRow = userSelect;
                        editUsu.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsu.UsuariosRow);

                    }
                    break;
            }

            this.usuariosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Usuarios);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios formAdd = new frmAdicionarUsuarios();
            formAdd.ShowDialog();

            if (!string.IsNullOrEmpty(formAdd.usuariosRow?.Usuario))

                this.usuariosTableAdapter.Insert(
                                        formAdd.usuariosRow.Usuario,
                                        true,
                                        1,
                                        1,
                                        DateTime.Now,
                                        DateTime.Now
            );
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);
        }
    }
}
