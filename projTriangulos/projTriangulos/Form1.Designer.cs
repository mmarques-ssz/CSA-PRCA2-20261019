namespace projTriangulos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClassificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.radNFT = new System.Windows.Forms.RadioButton();
            this.radEQ = new System.Windows.Forms.RadioButton();
            this.radIS = new System.Windows.Forms.RadioButton();
            this.radES = new System.Windows.Forms.RadioButton();
            this.picClassificacao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClassificacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(29, 36);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 0;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(29, 87);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 1;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(29, 144);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LADO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LADO 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LADO 3";
            // 
            // btnClassificar
            // 
            this.btnClassificar.Location = new System.Drawing.Point(32, 184);
            this.btnClassificar.Name = "btnClassificar";
            this.btnClassificar.Size = new System.Drawing.Size(97, 44);
            this.btnClassificar.TabIndex = 6;
            this.btnClassificar.Text = "Classificar";
            this.btnClassificar.UseVisualStyleBackColor = true;
            this.btnClassificar.Click += new System.EventHandler(this.click_classificar);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Classificação";
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(137, 258);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(0, 13);
            this.lblClassificacao.TabIndex = 8;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Enabled = false;
            this.txtClassificacao.Location = new System.Drawing.Point(173, 251);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(145, 20);
            this.txtClassificacao.TabIndex = 9;
            // 
            // radNFT
            // 
            this.radNFT.AutoSize = true;
            this.radNFT.Enabled = false;
            this.radNFT.Location = new System.Drawing.Point(204, 17);
            this.radNFT.Name = "radNFT";
            this.radNFT.Size = new System.Drawing.Size(155, 17);
            this.radNFT.TabIndex = 13;
            this.radNFT.TabStop = true;
            this.radNFT.Text = "NÃO FORMA TRIÂNGULO";
            this.radNFT.UseVisualStyleBackColor = true;
            // 
            // radEQ
            // 
            this.radEQ.AutoSize = true;
            this.radEQ.Enabled = false;
            this.radEQ.Location = new System.Drawing.Point(204, 42);
            this.radEQ.Name = "radEQ";
            this.radEQ.Size = new System.Drawing.Size(160, 17);
            this.radEQ.TabIndex = 14;
            this.radEQ.TabStop = true;
            this.radEQ.Text = "TRIÂNGULO EQUILÁTERO";
            this.radEQ.UseVisualStyleBackColor = true;
            // 
            // radIS
            // 
            this.radIS.AutoSize = true;
            this.radIS.Enabled = false;
            this.radIS.Location = new System.Drawing.Point(204, 66);
            this.radIS.Name = "radIS";
            this.radIS.Size = new System.Drawing.Size(150, 17);
            this.radIS.TabIndex = 15;
            this.radIS.TabStop = true;
            this.radIS.Text = "TRIÂNGULO ISÓSCELES";
            this.radIS.UseVisualStyleBackColor = true;
            // 
            // radES
            // 
            this.radES.AutoSize = true;
            this.radES.Enabled = false;
            this.radES.Location = new System.Drawing.Point(204, 89);
            this.radES.Name = "radES";
            this.radES.Size = new System.Drawing.Size(140, 17);
            this.radES.TabIndex = 16;
            this.radES.TabStop = true;
            this.radES.Text = "TRIÂGULO ESCALENO";
            this.radES.UseVisualStyleBackColor = true;
            // 
            // picClassificacao
            // 
            this.picClassificacao.Location = new System.Drawing.Point(229, 128);
            this.picClassificacao.Name = "picClassificacao";
            this.picClassificacao.Size = new System.Drawing.Size(225, 118);
            this.picClassificacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClassificacao.TabIndex = 17;
            this.picClassificacao.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 302);
            this.Controls.Add(this.picClassificacao);
            this.Controls.Add(this.radES);
            this.Controls.Add(this.radIS);
            this.Controls.Add(this.radEQ);
            this.Controls.Add(this.radNFT);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClassificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picClassificacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClassificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.RadioButton radNFT;
        private System.Windows.Forms.RadioButton radEQ;
        private System.Windows.Forms.RadioButton radIS;
        private System.Windows.Forms.RadioButton radES;
        private System.Windows.Forms.PictureBox picClassificacao;
    }
}

