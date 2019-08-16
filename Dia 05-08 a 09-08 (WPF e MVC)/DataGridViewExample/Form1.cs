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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Carros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }
        private void FrmVendas_Click(object sender, EventArgs e)
        {
            Form4 frmVendas = new Form4();
            frmVendas.ShowDialog();
        }
        private void FrmUsuarios_Click(object sender, EventArgs e)
        {
            Form3 frmUsuarios = new Form3();
            frmUsuarios.ShowDialog();
        }
        private void FrmAdicionar_Click(object sender, EventArgs e)
        {
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var carSelect = ((System.Data.DataRowView)                              //foi isolado pois são objetos diferentes "( )"
            //    this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            //as DataGridViewExample.QuerysInnerJoinDataSet1.CarrosRow;               //*DataGridViewExample = nome do namespace           
            //                                                                        //Este código ta convertendo toda a linha selecionada para uma
            //switch (e.ColumnIndex)
            //{   
            //    case 0: //Deletar
            //        {
            //            this.carrosTableAdapter.DeleteQuery(carSelect.Id);
            //        } break;
            //    case 1: //Editar
            //        {
            //            frmEdicaoCarros editCar = new frmEdicaoCarros();
            //            editCar.CarrosRow = carSelect;                            //vai selecionar o carro e depois fazer a edição
            //            editCar.ShowDialog();                                     //se for apenas ".Show();", morre o contexto. não realiza o desejado.

            //            this.carrosTableAdapter.Update(editCar.CarrosRow);        //atualiza todos os campos

            //            /*this.carrosTableAdapter.UpdateQuery1(editCar.CarrosRow.Modelo,
            //                                                 editCar.CarrosRow.Ano.ToString(),
            //                                                 editCar.CarrosRow.Marca,
            //                                                 editCar.CarrosRow.UsuAlt,
            //                                                 DateTime.Now,
            //                                                 editCar.CarrosRow.Id);*/
            //        } break;
            //}

            //this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);         //antes era Custon

        }

        private void frmCarros_Click_1(object sender, EventArgs e)
        {
            Form5AddCarros frmAddCarros = new Form5AddCarros();
            frmAddCarros.ShowDialog();

            //frmAdicionar formAdd = new frmAdicionar();
            //formAdd.ShowDialog();
            //                                                      //a propriedade modelo é vazia ou nula? sim, não
            //if (!string.IsNullOrEmpty(formAdd.carrosRow?.Modelo)) //"?! valida se carros for nulo, se for não existe nem modelo. Sim ou Não

            //    this.carrosTableAdapter.Insert (
            //                            formAdd.carrosRow.Modelo,
            //                            formAdd.carrosRow.Ano,
            //                            formAdd.carrosRow.Marca,
            //                            true,
            //                            1,
            //                            1,
            //                            DateTime.Now,
            //                            DateTime.Now
            //);
            //this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Lixeira frmlixeira = new Lixeira();
            frmlixeira.ShowDialog();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
