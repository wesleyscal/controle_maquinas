namespace controle_maquinas
{
    partial class NovaLicenca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaLicenca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSoftware = new System.Windows.Forms.ComboBox();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.rdbMultiplas = new System.Windows.Forms.RadioButton();
            this.rdbUnica = new System.Windows.Forms.RadioButton();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNfe = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbSoftware);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Software";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Software";
            // 
            // cbbSoftware
            // 
            this.cbbSoftware.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoftware.FormattingEnabled = true;
            this.cbbSoftware.Location = new System.Drawing.Point(8, 34);
            this.cbbSoftware.Name = "cbbSoftware";
            this.cbbSoftware.Size = new System.Drawing.Size(294, 21);
            this.cbbSoftware.TabIndex = 0;
            // 
            // btnSoftware
            // 
            this.btnSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftware.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftware.ForeColor = System.Drawing.Color.Gold;
            this.btnSoftware.Location = new System.Drawing.Point(10, 15);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(113, 49);
            this.btnSoftware.TabIndex = 1;
            this.btnSoftware.Text = "Novo Software";
            this.btnSoftware.UseVisualStyleBackColor = false;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.rdbMultiplas);
            this.groupBox2.Controls.Add(this.rdbUnica);
            this.groupBox2.Controls.Add(this.txtObservacao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNfe);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.txtKey);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nova Licença";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantidade.Location = new System.Drawing.Point(328, 88);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(113, 20);
            this.txtQuantidade.TabIndex = 17;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // rdbMultiplas
            // 
            this.rdbMultiplas.AutoSize = true;
            this.rdbMultiplas.Location = new System.Drawing.Point(209, 92);
            this.rdbMultiplas.Name = "rdbMultiplas";
            this.rdbMultiplas.Size = new System.Drawing.Size(106, 17);
            this.rdbMultiplas.TabIndex = 16;
            this.rdbMultiplas.Text = "Licença multiplas";
            this.rdbMultiplas.UseVisualStyleBackColor = true;
            this.rdbMultiplas.CheckedChanged += new System.EventHandler(this.rdbMultiplas_CheckedChanged);
            // 
            // rdbUnica
            // 
            this.rdbUnica.AutoSize = true;
            this.rdbUnica.Checked = true;
            this.rdbUnica.Location = new System.Drawing.Point(209, 71);
            this.rdbUnica.Name = "rdbUnica";
            this.rdbUnica.Size = new System.Drawing.Size(94, 17);
            this.rdbUnica.TabIndex = 15;
            this.rdbUnica.TabStop = true;
            this.rdbUnica.Text = "Licença Unica";
            this.rdbUnica.UseVisualStyleBackColor = true;
            this.rdbUnica.CheckedChanged += new System.EventHandler(this.rdbUnica_CheckedChanged);
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtObservacao.Location = new System.Drawing.Point(9, 114);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(432, 89);
            this.txtObservacao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Observação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "NF-e";
            // 
            // txtNfe
            // 
            this.txtNfe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNfe.Location = new System.Drawing.Point(9, 71);
            this.txtNfe.Name = "txtNfe";
            this.txtNfe.Size = new System.Drawing.Size(194, 20);
            this.txtNfe.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(328, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 46);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
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
            this.btnSalvar.Location = new System.Drawing.Point(209, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 46);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKey.Location = new System.Drawing.Point(9, 32);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(194, 20);
            this.txtKey.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoftware);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(331, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Novo";
            // 
            // NovaLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(479, 310);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "NovaLicenca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Software";
            this.Load += new System.EventHandler(this.NovaLicenca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NovaLicenca_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbSoftware;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNfe;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbMultiplas;
        private System.Windows.Forms.RadioButton rdbUnica;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}