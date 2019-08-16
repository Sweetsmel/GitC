namespace CadastroDeAlunos
{
    partial class TelaInicialBotaoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicialBotaoCadastro));
            this.tbxCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxCadastro
            // 
            this.tbxCadastro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbxCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbxCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCadastro.Location = new System.Drawing.Point(294, 148);
            this.tbxCadastro.Name = "tbxCadastro";
            this.tbxCadastro.Size = new System.Drawing.Size(189, 59);
            this.tbxCadastro.TabIndex = 0;
            this.tbxCadastro.Text = "CADASTRAR ALUNO";
            this.tbxCadastro.UseVisualStyleBackColor = false;
            this.tbxCadastro.Click += new System.EventHandler(this.TbxCadastro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 414);
            this.Controls.Add(this.tbxCadastro);
            this.Name = "Form1";
            this.Text = "TelaInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbxCadastro;
    }
}

