namespace PsPen
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pcbExcluir = new System.Windows.Forms.PictureBox();
            this.pcbIgnorar = new System.Windows.Forms.PictureBox();
            this.pcbAtualizarBilioteca = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIgnorar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtualizarBilioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PsPen.Properties.Resources.pendriveedt;
            this.pictureBox1.Location = new System.Drawing.Point(610, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 81);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "PsPen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(374, 105);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 70);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Arquivo malicioso \r\nnão encontrado";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeArquivo.Location = new System.Drawing.Point(481, 214);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(36, 25);
            this.lblNomeArquivo.TabIndex = 5;
            this.lblNomeArquivo.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Atualizar Biblioteca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ignorar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(797, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Excluir";
            // 
            // pcbExcluir
            // 
            this.pcbExcluir.Image = global::PsPen.Properties.Resources.trash_canedt;
            this.pcbExcluir.Location = new System.Drawing.Point(761, 346);
            this.pcbExcluir.Name = "pcbExcluir";
            this.pcbExcluir.Size = new System.Drawing.Size(150, 150);
            this.pcbExcluir.TabIndex = 9;
            this.pcbExcluir.TabStop = false;
            this.pcbExcluir.Click += new System.EventHandler(this.pcbExcluir_Click);
            // 
            // pcbIgnorar
            // 
            this.pcbIgnorar.Image = global::PsPen.Properties.Resources.closed_eyeedt;
            this.pcbIgnorar.Location = new System.Drawing.Point(457, 346);
            this.pcbIgnorar.Name = "pcbIgnorar";
            this.pcbIgnorar.Size = new System.Drawing.Size(150, 150);
            this.pcbIgnorar.TabIndex = 8;
            this.pcbIgnorar.TabStop = false;
            this.pcbIgnorar.Click += new System.EventHandler(this.pcbIgnorar_Click);
            // 
            // pcbAtualizarBilioteca
            // 
            this.pcbAtualizarBilioteca.Image = global::PsPen.Properties.Resources.bookshelfedt;
            this.pcbAtualizarBilioteca.Location = new System.Drawing.Point(157, 346);
            this.pcbAtualizarBilioteca.Name = "pcbAtualizarBilioteca";
            this.pcbAtualizarBilioteca.Size = new System.Drawing.Size(150, 150);
            this.pcbAtualizarBilioteca.TabIndex = 7;
            this.pcbAtualizarBilioteca.TabStop = false;
            this.pcbAtualizarBilioteca.Click += new System.EventHandler(this.pcbAtualizarBilioteca_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PsPen.Properties.Resources.warningedt;
            this.pictureBox2.Location = new System.Drawing.Point(380, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 62);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 578);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pcbExcluir);
            this.Controls.Add(this.pcbIgnorar);
            this.Controls.Add(this.pcbAtualizarBilioteca);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "PsPen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIgnorar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtualizarBilioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbAtualizarBilioteca;
        private System.Windows.Forms.PictureBox pcbIgnorar;
        private System.Windows.Forms.PictureBox pcbExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}