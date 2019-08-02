namespace DataGridViewExample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.querysInnerJoinDataSet1 = new DataGridViewExample.QuerysInnerJoinDataSet1();
            this.frmMarcas = new System.Windows.Forms.Button();
            this.frmVendas = new System.Windows.Forms.Button();
            this.frmUsuarios = new System.Windows.Forms.Button();
            this.carrosTableAdapter = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.CarrosTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frmCarros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.querysInnerJoinDataSet1;
            // 
            // querysInnerJoinDataSet1
            // 
            this.querysInnerJoinDataSet1.DataSetName = "QuerysInnerJoinDataSet1";
            this.querysInnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmMarcas
            // 
            this.frmMarcas.BackColor = System.Drawing.Color.Transparent;
            this.frmMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMarcas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.frmMarcas.Location = new System.Drawing.Point(835, 450);
            this.frmMarcas.Name = "frmMarcas";
            this.frmMarcas.Size = new System.Drawing.Size(148, 37);
            this.frmMarcas.TabIndex = 2;
            this.frmMarcas.Text = "Marcas";
            this.frmMarcas.UseVisualStyleBackColor = false;
            this.frmMarcas.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmVendas
            // 
            this.frmVendas.BackColor = System.Drawing.Color.Transparent;
            this.frmVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmVendas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmVendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.frmVendas.Location = new System.Drawing.Point(835, 564);
            this.frmVendas.Name = "frmVendas";
            this.frmVendas.Size = new System.Drawing.Size(148, 37);
            this.frmVendas.TabIndex = 3;
            this.frmVendas.Text = "Vendas";
            this.frmVendas.UseVisualStyleBackColor = false;
            this.frmVendas.Click += new System.EventHandler(this.FrmVendas_Click);
            // 
            // frmUsuarios
            // 
            this.frmUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.frmUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.frmUsuarios.Location = new System.Drawing.Point(835, 507);
            this.frmUsuarios.Name = "frmUsuarios";
            this.frmUsuarios.Size = new System.Drawing.Size(148, 37);
            this.frmUsuarios.TabIndex = 4;
            this.frmUsuarios.Text = "Usuarios";
            this.frmUsuarios.UseVisualStyleBackColor = false;
            this.frmUsuarios.Click += new System.EventHandler(this.FrmUsuarios_Click);
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1068, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // frmCarros
            // 
            this.frmCarros.BackColor = System.Drawing.Color.Transparent;
            this.frmCarros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmCarros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmCarros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmCarros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.frmCarros.Location = new System.Drawing.Point(835, 389);
            this.frmCarros.Name = "frmCarros";
            this.frmCarros.Size = new System.Drawing.Size(148, 37);
            this.frmCarros.TabIndex = 8;
            this.frmCarros.Text = "Carros";
            this.frmCarros.UseVisualStyleBackColor = false;
            this.frmCarros.Click += new System.EventHandler(this.frmCarros_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1064, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lixeira";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(920, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registros:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1019, 529);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1019, 414);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 620);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmCarros);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.frmUsuarios);
            this.Controls.Add(this.frmVendas);
            this.Controls.Add(this.frmMarcas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuerysInnerJoinDataSet1 querysInnerJoinDataSet1;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private QuerysInnerJoinDataSet1TableAdapters.CarrosTableAdapter carrosTableAdapter;
        private System.Windows.Forms.Button frmMarcas;
        private System.Windows.Forms.Button frmVendas;
        private System.Windows.Forms.Button frmUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button frmCarros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

