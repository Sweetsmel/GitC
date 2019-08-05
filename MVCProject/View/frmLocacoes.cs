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
    public partial class frmLocacoes : Form
    {
        public frmLocacoes()
        {
            InitializeComponent();
        }

        private void FrmLocacoes_Load(object sender, EventArgs e)
        {
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addLocacao locacaoAdd = new addLocacao();
            locacaoAdd.ShowDialog();

            //if (!string.IsNullOrEmpty(locacaoAdd.locacaoRow?.Livro))
            if (locacaoAdd.locacaoRow?.Livro > 0)

                            this.locacaoTableAdapter.Insert(
                                        locacaoAdd.locacaoRow.Livro,
                                        locacaoAdd.locacaoRow.Usuario,
                                        locacaoAdd.locacaoRow.Tipo,
                                        locacaoAdd.locacaoRow.Devolucao,
                                        locacaoAdd.locacaoRow.DiasAloc,
                                        true,
                                        1,
                                        1,
                                        DateTime.Now,
                                        DateTime.Now
            );
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:                             //Coluna deletar
                    {
                        this.locacaoTableAdapter.DeleteQuery(locacaoSelect.Id);
                    }
                    break;
                case 1:
                    {
                        editLocacao locacaoEdit = new editLocacao();
                        locacaoEdit.locacaoRow = locacaoSelect;
                        //locacaoEdit.locacaoRow = locacaoSelect;
                        locacaoEdit.ShowDialog();
                
                        this.locacaoTableAdapter.Update(locacaoEdit.locacaoRow);
                    }
                    break;
            }       

            this.locacaoTableAdapter.CustomQuery(sistemaBibliotecaDBDataSet.Locacao);
        }
    }
}
