namespace DataGridViewExample.Adicionar
{
    partial class frmAdicionarVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nrQuantAdd = new System.Windows.Forms.NumericUpDown();
            this.tbxValueAdd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCarAdd = new System.Windows.Forms.ComboBox();
            this.carrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.querysInnerJoinDataSet1 = new DataGridViewExample.QuerysInnerJoinDataSet1();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.CarrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // nrQuantAdd
            // 
            this.nrQuantAdd.Location = new System.Drawing.Point(124, 47);
            this.nrQuantAdd.Name = "nrQuantAdd";
            this.nrQuantAdd.Size = new System.Drawing.Size(177, 22);
            this.nrQuantAdd.TabIndex = 4;
            // 
            // tbxValueAdd
            // 
            this.tbxValueAdd.Location = new System.Drawing.Point(124, 78);
            this.tbxValueAdd.Name = "tbxValueAdd";
            this.tbxValueAdd.Size = new System.Drawing.Size(177, 22);
            this.tbxValueAdd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbCarAdd
            // 
            this.cbCarAdd.DataSource = this.carrosBindingSource1;
            this.cbCarAdd.DisplayMember = "Modelo";
            this.cbCarAdd.FormattingEnabled = true;
            this.cbCarAdd.Location = new System.Drawing.Point(124, 9);
            this.cbCarAdd.Name = "cbCarAdd";
            this.cbCarAdd.Size = new System.Drawing.Size(177, 24);
            this.cbCarAdd.TabIndex = 7;
            this.cbCarAdd.ValueMember = "Id";
            // 
            // carrosBindingSource1
            // 
            this.carrosBindingSource1.DataMember = "Carros";
            this.carrosBindingSource1.DataSource = this.querysInnerJoinDataSet1;
            // 
            // querysInnerJoinDataSet1
            // 
            this.querysInnerJoinDataSet1.DataSetName = "QuerysInnerJoinDataSet1";
            this.querysInnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.querysInnerJoinDataSet1;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdicionarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(313, 259);
            this.Controls.Add(this.cbCarAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxValueAdd);
            this.Controls.Add(this.nrQuantAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmAdicionarVendas";
            this.Text = "frmAdicionarVendas";
            this.Load += new System.EventHandler(this.FrmAdicionarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nrQuantAdd;
        private System.Windows.Forms.TextBox tbxValueAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCarAdd;
        private QuerysInnerJoinDataSet1 querysInnerJoinDataSet1;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private System.Windows.Forms.BindingSource carrosBindingSource1;
        private QuerysInnerJoinDataSet1TableAdapters.CarrosTableAdapter carrosTableAdapter;
    }
}