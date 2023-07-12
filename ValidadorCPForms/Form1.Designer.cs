namespace ValidadorCPForms
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
            System.Windows.Forms.Label lbldigitecpf;
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvalidarcpf = new System.Windows.Forms.Button();
            this.lblgeradordecpf = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btngerarcpf = new System.Windows.Forms.Button();
            lbldigitecpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldigitecpf
            // 
            lbldigitecpf.AutoSize = true;
            lbldigitecpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbldigitecpf.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbldigitecpf.Location = new System.Drawing.Point(91, 30);
            lbldigitecpf.Name = "lbldigitecpf";
            lbldigitecpf.Size = new System.Drawing.Size(98, 20);
            lbldigitecpf.TabIndex = 2;
            lbldigitecpf.Text = "Digite o CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt1.Location = new System.Drawing.Point(26, 70);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(224, 20);
            this.txt1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // btnvalidarcpf
            // 
            this.btnvalidarcpf.Location = new System.Drawing.Point(68, 112);
            this.btnvalidarcpf.Name = "btnvalidarcpf";
            this.btnvalidarcpf.Size = new System.Drawing.Size(158, 40);
            this.btnvalidarcpf.TabIndex = 4;
            this.btnvalidarcpf.Text = "Validar CPF";
            this.btnvalidarcpf.UseVisualStyleBackColor = true;
            this.btnvalidarcpf.Click += new System.EventHandler(this.btnvalidarcpf_Click);
            // 
            // lblgeradordecpf
            // 
            this.lblgeradordecpf.AutoSize = true;
            this.lblgeradordecpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgeradordecpf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblgeradordecpf.Location = new System.Drawing.Point(91, 177);
            this.lblgeradordecpf.Name = "lblgeradordecpf";
            this.lblgeradordecpf.Size = new System.Drawing.Size(125, 20);
            this.lblgeradordecpf.TabIndex = 5;
            this.lblgeradordecpf.Text = "Gerador de CPF";
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt2.Location = new System.Drawing.Point(26, 217);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(224, 20);
            this.txt2.TabIndex = 6;
            // 
            // btngerarcpf
            // 
            this.btngerarcpf.Location = new System.Drawing.Point(68, 266);
            this.btngerarcpf.Name = "btngerarcpf";
            this.btngerarcpf.Size = new System.Drawing.Size(158, 52);
            this.btngerarcpf.TabIndex = 7;
            this.btngerarcpf.Text = "Gerar cpf";
            this.btngerarcpf.UseVisualStyleBackColor = true;
            this.btngerarcpf.Click += new System.EventHandler(this.btngerarcpf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 360);
            this.Controls.Add(this.btngerarcpf);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lblgeradordecpf);
            this.Controls.Add(this.btnvalidarcpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(lbldigitecpf);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "Form1";
            this.Text = "Sistema CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvalidarcpf;
        private System.Windows.Forms.Label lblgeradordecpf;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btngerarcpf;
    }
}

