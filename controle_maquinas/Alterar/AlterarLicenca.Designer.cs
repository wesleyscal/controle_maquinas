namespace controle_maquinas
{
    partial class AlterarLicenca
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
            this.rdbMultiplas = new System.Windows.Forms.RadioButton();
            this.rdbUnica = new System.Windows.Forms.RadioButton();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNfe = new System.Windows.Forms.TextBox();
            this.btnResetar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.ckbDisponivel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoftware = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbMultiplas
            // 
            this.rdbMultiplas.AutoSize = true;
            this.rdbMultiplas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMultiplas.ForeColor = System.Drawing.SystemColors.Window;
            this.rdbMultiplas.Location = new System.Drawing.Point(6, 72);
            this.rdbMultiplas.Name = "rdbMultiplas";
            this.rdbMultiplas.Size = new System.Drawing.Size(139, 22);
            this.rdbMultiplas.TabIndex = 16;
            this.rdbMultiplas.Text = "Licença Multiplas";
            this.rdbMultiplas.UseVisualStyleBackColor = true;
            // 
            // rdbUnica
            // 
            this.rdbUnica.AutoSize = true;
            this.rdbUnica.Checked = true;
            this.rdbUnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUnica.ForeColor = System.Drawing.SystemColors.Window;
            this.rdbUnica.Location = new System.Drawing.Point(6, 29);
            this.rdbUnica.Name = "rdbUnica";
            this.rdbUnica.Size = new System.Drawing.Size(119, 22);
            this.rdbUnica.TabIndex = 15;
            this.rdbUnica.TabStop = true;
            this.rdbUnica.Text = "Licença Unica";
            this.rdbUnica.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtObservacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacao.Location = new System.Drawing.Point(3, 16);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(696, 81);
            this.txtObservacao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "NF-e";
            // 
            // txtNfe
            // 
            this.txtNfe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNfe.Location = new System.Drawing.Point(9, 118);
            this.txtNfe.Name = "txtNfe";
            this.txtNfe.Size = new System.Drawing.Size(501, 20);
            this.txtNfe.TabIndex = 2;
            // 
            // btnResetar
            // 
            this.btnResetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetar.ForeColor = System.Drawing.Color.Gold;
            this.btnResetar.Location = new System.Drawing.Point(602, 274);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(112, 46);
            this.btnResetar.TabIndex = 5;
            this.btnResetar.Text = "Resetar Padrão";
            this.btnResetar.UseVisualStyleBackColor = false;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Key";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Gold;
            this.btnSalvar.Location = new System.Drawing.Point(484, 274);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 46);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKey.Location = new System.Drawing.Point(9, 75);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(501, 20);
            this.txtKey.TabIndex = 1;
            // 
            // ckbDisponivel
            // 
            this.ckbDisponivel.AutoSize = true;
            this.ckbDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDisponivel.ForeColor = System.Drawing.Color.White;
            this.ckbDisponivel.Location = new System.Drawing.Point(6, 116);
            this.ckbDisponivel.Name = "ckbDisponivel";
            this.ckbDisponivel.Size = new System.Drawing.Size(95, 22);
            this.ckbDisponivel.TabIndex = 17;
            this.ckbDisponivel.Text = "Disponivel";
            this.ckbDisponivel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Software";
            // 
            // txtSoftware
            // 
            this.txtSoftware.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoftware.Location = new System.Drawing.Point(9, 32);
            this.txtSoftware.Name = "txtSoftware";
            this.txtSoftware.ReadOnly = true;
            this.txtSoftware.Size = new System.Drawing.Size(501, 20);
            this.txtSoftware.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNfe);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoftware);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 150);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Software / Licença:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbUnica);
            this.groupBox2.Controls.Add(this.ckbDisponivel);
            this.groupBox2.Controls.Add(this.rdbMultiplas);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(534, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 150);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções da Licença:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObservacao);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(702, 100);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observações:";
            // 
            // AlterarLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(725, 333);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnResetar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AlterarLicenca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Licenca";
            this.Load += new System.EventHandler(this.AlterarLicenca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMultiplas;
        private System.Windows.Forms.RadioButton rdbUnica;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNfe;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.CheckBox ckbDisponivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoftware;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}