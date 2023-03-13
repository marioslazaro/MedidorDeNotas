namespace MedidorDeNotas
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lbl06 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(158, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "nome";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(343, 12);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(82, 20);
            this.dtData.TabIndex = 2;
            this.dtData.Value = new System.DateTime(2053, 3, 13, 15, 8, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Biologia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Portugues";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Matematica";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(161, 103);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(100, 20);
            this.txtMat.TabIndex = 6;
            this.txtMat.Text = "0";
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(161, 148);
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(100, 20);
            this.txtBio.TabIndex = 7;
            this.txtBio.Text = "0";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(161, 195);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "0";
            // 
            // txtHis
            // 
            this.txtHis.Location = new System.Drawing.Point(161, 239);
            this.txtHis.Name = "txtHis";
            this.txtHis.Size = new System.Drawing.Size(100, 20);
            this.txtHis.TabIndex = 9;
            this.txtHis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Historia";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(175, 310);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 11;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lbl06
            // 
            this.lbl06.AutoSize = true;
            this.lbl06.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl06.Location = new System.Drawing.Point(30, 352);
            this.lbl06.Name = "lbl06";
            this.lbl06.Size = new System.Drawing.Size(56, 20);
            this.lbl06.TabIndex = 13;
            this.lbl06.Text = "Média:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(106, 355);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(16, 17);
            this.lblMedia.TabIndex = 14;
            this.lblMedia.Text = "0";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(106, 401);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(20, 17);
            this.lblSituacao.TabIndex = 16;
            this.lblSituacao.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Situação:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(428, 433);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lbl06);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHis);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lbl06;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label label7;
    }
}

