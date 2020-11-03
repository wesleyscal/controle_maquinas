namespace controle_maquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbKey = new System.Windows.Forms.ComboBox();
            this.cbbSoftware = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnNovoSoftware = new System.Windows.Forms.Button();
            this.btnNovaMaquina = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSoftwareLicenca = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.cbbKey);
            this.groupBox1.Controls.Add(this.cbbSoftware);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaquina);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // cbbKey
            // 
            this.cbbKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKey.FormattingEnabled = true;
            this.cbbKey.Location = new System.Drawing.Point(285, 36);
            this.cbbKey.Name = "cbbKey";
            this.cbbKey.Size = new System.Drawing.Size(187, 23);
            this.cbbKey.TabIndex = 28;
            // 
            // cbbSoftware
            // 
            this.cbbSoftware.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoftware.FormattingEnabled = true;
            this.cbbSoftware.Location = new System.Drawing.Point(144, 36);
            this.cbbSoftware.Name = "cbbSoftware";
            this.cbbSoftware.Size = new System.Drawing.Size(135, 23);
            this.cbbSoftware.TabIndex = 8;
            this.cbbSoftware.SelectedIndexChanged += new System.EventHandler(this.cbbSoftware_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Gold;
            this.btnPesquisar.Location = new System.Drawing.Point(552, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(107, 41);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Software";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maquina";
            // 
            // txtMaquina
            // 
            this.txtMaquina.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaquina.Location = new System.Drawing.Point(6, 36);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.Size = new System.Drawing.Size(132, 21);
            this.txtMaquina.TabIndex = 0;
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Location = new System.Drawing.Point(13, 85);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.Size = new System.Drawing.Size(914, 439);
            this.dgvMaquinas.TabIndex = 1;
            this.dgvMaquinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaquinas_CellDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 588);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(941, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "|| F2 - Atualizar ||";
            // 
            // btnNovoSoftware
            // 
            this.btnNovoSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovoSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoSoftware.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoSoftware.ForeColor = System.Drawing.Color.Gold;
            this.btnNovoSoftware.Location = new System.Drawing.Point(121, 17);
            this.btnNovoSoftware.Name = "btnNovoSoftware";
            this.btnNovoSoftware.Size = new System.Drawing.Size(107, 41);
            this.btnNovoSoftware.TabIndex = 3;
            this.btnNovoSoftware.Text = " Nova  Licença";
            this.btnNovoSoftware.UseVisualStyleBackColor = false;
            this.btnNovoSoftware.Click += new System.EventHandler(this.btnNovoSoftware_Click);
            // 
            // btnNovaMaquina
            // 
            this.btnNovaMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovaMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaMaquina.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaMaquina.ForeColor = System.Drawing.Color.Gold;
            this.btnNovaMaquina.Location = new System.Drawing.Point(8, 17);
            this.btnNovaMaquina.Name = "btnNovaMaquina";
            this.btnNovaMaquina.Size = new System.Drawing.Size(107, 41);
            this.btnNovaMaquina.TabIndex = 4;
            this.btnNovaMaquina.Text = " Nova  Maquina";
            this.btnNovaMaquina.UseVisualStyleBackColor = false;
            this.btnNovaMaquina.Click += new System.EventHandler(this.btnNovaMaquina_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovoSoftware);
            this.groupBox2.Controls.Add(this.btnNovaMaquina);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(688, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo";
            // 
            // btnSoftwareLicenca
            // 
            this.btnSoftwareLicenca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSoftwareLicenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftwareLicenca.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftwareLicenca.ForeColor = System.Drawing.Color.Gold;
            this.btnSoftwareLicenca.Location = new System.Drawing.Point(820, 530);
            this.btnSoftwareLicenca.Name = "btnSoftwareLicenca";
            this.btnSoftwareLicenca.Size = new System.Drawing.Size(107, 52);
            this.btnSoftwareLicenca.TabIndex = 29;
            this.btnSoftwareLicenca.Text = "Softwares Licenças";
            this.btnSoftwareLicenca.UseVisualStyleBackColor = false;
            this.btnSoftwareLicenca.Click += new System.EventHandler(this.btnSoftwareLicenca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(939, 607);
            this.Controls.Add(this.btnSoftwareLicenca);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvMaquinas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle De Maquinas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoSoftware;
        private System.Windows.Forms.Button btnNovaMaquina;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSoftware;
        private System.Windows.Forms.ComboBox cbbKey;
        private System.Windows.Forms.Button btnSoftwareLicenca;
    }
}

