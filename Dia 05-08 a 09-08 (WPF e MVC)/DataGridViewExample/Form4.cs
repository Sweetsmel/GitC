﻿using DataGridViewExample.Adicionar;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas frmAddVendas = new frmAdicionarVendas();
            frmAddVendas.ShowDialog();

            if (frmAddVendas.vendasRow?.Carro > 0 && frmAddVendas.vendasRow?.Valor > 0)       //carro e valor

            //if (!string.IsNullOrEmpty(formAdd.vendasRow?.Carro))


                    this.vendasTableAdapter.Insert(
                                        frmAddVendas.vendasRow.Carro,
                                        frmAddVendas.vendasRow.Quantidade,
                                        frmAddVendas.vendasRow.Valor,
                                        true,
                                        1,
                                        1,
                                        DateTime.Now,
                                        DateTime.Now
            );
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0: //Coluna deletar
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoVendas editVenda = new frmEdicaoVendas();
                        editVenda.VendasRow = vendasSelect;
                        editVenda.ShowDialog();

                        this.vendasTableAdapter.Update(editVenda.VendasRow);
                    }
                    break;

                  

            }
            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Vendas);
        }
    }
}
