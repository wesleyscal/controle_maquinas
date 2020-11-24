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
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnNovoSoftware = new System.Windows.Forms.Button();
            this.btnNovaMaquina = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSoftwareLicenca = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // cbbKey
            // 
            this.cbbKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKey.FormattingEnabled = true;
            this.cbbKey.Location = new System.Drawing.Point(246, 51);
            this.cbbKey.Name = "cbbKey";
            this.cbbKey.Size = new System.Drawing.Size(300, 23);
            this.cbbKey.TabIndex = 28;
            // 
            // cbbSoftware
            // 
            this.cbbSoftware.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoftware.FormattingEnabled = true;
            this.cbbSoftware.Location = new System.Drawing.Point(6, 51);
            this.cbbSoftware.Name = "cbbSoftware";
            this.cbbSoftware.Size = new System.Drawing.Size(234, 23);
            this.cbbSoftware.TabIndex = 8;
            this.cbbSoftware.SelectedIndexChanged += new System.EventHandler(this.cbbSoftware_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 35);
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
            this.btnPesquisar.Size = new System.Drawing.Size(107, 57);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Software";
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.AllowUserToAddRows = false;
            this.dgvMaquinas.AllowUserToDeleteRows = false;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Location = new System.Drawing.Point(13, 98);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.ReadOnly = true;
            this.dgvMaquinas.Size = new System.Drawing.Size(1088, 483);
            this.dgvMaquinas.TabIndex = 1;
            this.dgvMaquinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaquinas_CellDoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 587);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1135, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "|| F2 - Atualizar || F3 - Pesquisar Por Nome Real || F4 - banco de dados ||";
            // 
            // btnNovoSoftware
            // 
            this.btnNovoSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovoSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoSoftware.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoSoftware.ForeColor = System.Drawing.Color.Gold;
            this.btnNovoSoftware.Location = new System.Drawing.Point(121, 17);
            this.btnNovoSoftware.Name = "btnNovoSoftware";
            this.btnNovoSoftware.Size = new System.Drawing.Size(107, 57);
            this.btnNovoSoftware.TabIndex = 3;
            this.btnNovoSoftware.Text = " Novo  Software  Licença";
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
            this.btnNovaMaquina.Size = new System.Drawing.Size(107, 57);
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
            this.groupBox2.Location = new System.Drawing.Point(685, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 80);
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
            this.btnSoftwareLicenca.Location = new System.Drawing.Point(6, 16);
            this.btnSoftwareLicenca.Name = "btnSoftwareLicenca";
            this.btnSoftwareLicenca.Size = new System.Drawing.Size(157, 57);
            this.btnSoftwareLicenca.TabIndex = 29;
            this.btnSoftwareLicenca.Text = "Softwares e Licenças";
            this.btnSoftwareLicenca.UseVisualStyleBackColor = false;
            this.btnSoftwareLicenca.Click += new System.EventHandler(this.btnSoftwareLicenca_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoftwareLicenca);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(931, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 79);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestão";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1110, 607);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnNovoSoftware;
        private System.Windows.Forms.Button btnNovaMaquina;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSoftware;
        private System.Windows.Forms.Button btnSoftwareLicenca;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox cbbKey;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}

