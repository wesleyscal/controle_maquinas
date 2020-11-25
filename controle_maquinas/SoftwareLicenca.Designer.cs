namespace controle_maquinas
{
    partial class SoftwareLicenca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareLicenca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSoftware = new System.Windows.Forms.DataGridView();
            this.btnRemoverSoftware = new System.Windows.Forms.Button();
            this.btnAdicionarSoftware = new System.Windows.Forms.Button();
            this.gpbLicenca = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNfe = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnRemoverLicenca = new System.Windows.Forms.Button();
            this.dgvLicenca = new System.Windows.Forms.DataGridView();
            this.btnAdicionarLicenca = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).BeginInit();
            this.gpbLicenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSoftware);
            this.groupBox1.Controls.Add(this.btnRemoverSoftware);
            this.groupBox1.Controls.Add(this.btnAdicionarSoftware);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Software";
            // 
            // dgvSoftware
            // 
            this.dgvSoftware.AllowUserToAddRows = false;
            this.dgvSoftware.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSoftware.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoftware.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoftware.Location = new System.Drawing.Point(6, 19);
            this.dgvSoftware.Name = "dgvSoftware";
            this.dgvSoftware.ReadOnly = true;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvSoftware.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSoftware.Size = new System.Drawing.Size(227, 335);
            this.dgvSoftware.TabIndex = 0;
            this.dgvSoftware.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftware_CellClick);
            this.dgvSoftware.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftware_CellDoubleClick);
            // 
            // btnRemoverSoftware
            // 
            this.btnRemoverSoftware.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoverSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverSoftware.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverSoftware.ForeColor = System.Drawing.Color.Gold;
            this.btnRemoverSoftware.Location = new System.Drawing.Point(126, 359);
            this.btnRemoverSoftware.Name = "btnRemoverSoftware";
            this.btnRemoverSoftware.Size = new System.Drawing.Size(107, 45);
            this.btnRemoverSoftware.TabIndex = 31;
            this.btnRemoverSoftware.Text = "Remover Software";
            this.btnRemoverSoftware.UseVisualStyleBackColor = false;
            this.btnRemoverSoftware.Click += new System.EventHandler(this.btnRemoverSoftware_Click);
            // 
            // btnAdicionarSoftware
            // 
            this.btnAdicionarSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSoftware.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarSoftware.ForeColor = System.Drawing.Color.Gold;
            this.btnAdicionarSoftware.Location = new System.Drawing.Point(6, 359);
            this.btnAdicionarSoftware.Name = "btnAdicionarSoftware";
            this.btnAdicionarSoftware.Size = new System.Drawing.Size(107, 45);
            this.btnAdicionarSoftware.TabIndex = 30;
            this.btnAdicionarSoftware.Text = "Adicionar Software";
            this.btnAdicionarSoftware.UseVisualStyleBackColor = false;
            this.btnAdicionarSoftware.Click += new System.EventHandler(this.btnAdicionarSoftware_Click);
            // 
            // gpbLicenca
            // 
            this.gpbLicenca.Controls.Add(this.label2);
            this.gpbLicenca.Controls.Add(this.txtNfe);
            this.gpbLicenca.Controls.Add(this.btnPesquisa);
            this.gpbLicenca.Controls.Add(this.label1);
            this.gpbLicenca.Controls.Add(this.txtKey);
            this.gpbLicenca.Controls.Add(this.btnRemoverLicenca);
            this.gpbLicenca.Controls.Add(this.dgvLicenca);
            this.gpbLicenca.Controls.Add(this.btnAdicionarLicenca);
            this.gpbLicenca.ForeColor = System.Drawing.Color.White;
            this.gpbLicenca.Location = new System.Drawing.Point(257, 12);
            this.gpbLicenca.Name = "gpbLicenca";
            this.gpbLicenca.Size = new System.Drawing.Size(789, 414);
            this.gpbLicenca.TabIndex = 1;
            this.gpbLicenca.TabStop = false;
            this.gpbLicenca.Text = "Licença";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "NF-e";
            // 
            // txtNfe
            // 
            this.txtNfe.Location = new System.Drawing.Point(235, 376);
            this.txtNfe.Name = "txtNfe";
            this.txtNfe.Size = new System.Drawing.Size(209, 20);
            this.txtNfe.TabIndex = 2;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.ForeColor = System.Drawing.Color.Gold;
            this.btnPesquisa.Location = new System.Drawing.Point(450, 360);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(107, 45);
            this.btnPesquisa.TabIndex = 3;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(9, 376);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(220, 20);
            this.txtKey.TabIndex = 1;
            // 
            // btnRemoverLicenca
            // 
            this.btnRemoverLicenca.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoverLicenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverLicenca.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverLicenca.ForeColor = System.Drawing.Color.Gold;
            this.btnRemoverLicenca.Location = new System.Drawing.Point(676, 360);
            this.btnRemoverLicenca.Name = "btnRemoverLicenca";
            this.btnRemoverLicenca.Size = new System.Drawing.Size(107, 45);
            this.btnRemoverLicenca.TabIndex = 5;
            this.btnRemoverLicenca.Text = "Remover licença";
            this.btnRemoverLicenca.UseVisualStyleBackColor = false;
            this.btnRemoverLicenca.Click += new System.EventHandler(this.btnRemoverLicenca_Click);
            // 
            // dgvLicenca
            // 
            this.dgvLicenca.AllowUserToAddRows = false;
            this.dgvLicenca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvLicenca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLicenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLicenca.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLicenca.Location = new System.Drawing.Point(6, 19);
            this.dgvLicenca.Name = "dgvLicenca";
            this.dgvLicenca.ReadOnly = true;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvLicenca.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLicenca.Size = new System.Drawing.Size(777, 335);
            this.dgvLicenca.TabIndex = 0;
            this.dgvLicenca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLicenca_CellDoubleClick);
            // 
            // btnAdicionarLicenca
            // 
            this.btnAdicionarLicenca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarLicenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarLicenca.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarLicenca.ForeColor = System.Drawing.Color.Gold;
            this.btnAdicionarLicenca.Location = new System.Drawing.Point(563, 360);
            this.btnAdicionarLicenca.Name = "btnAdicionarLicenca";
            this.btnAdicionarLicenca.Size = new System.Drawing.Size(107, 45);
            this.btnAdicionarLicenca.TabIndex = 4;
            this.btnAdicionarLicenca.Text = "Adicionar Licença";
            this.btnAdicionarLicenca.UseVisualStyleBackColor = false;
            this.btnAdicionarLicenca.Click += new System.EventHandler(this.btnAdicionarLicenca_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(1, 437);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1061, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "|| Duplo Clique Altera ||";
            // 
            // SoftwareLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1057, 457);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gpbLicenca);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SoftwareLicenca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software e Licenca";
            this.Load += new System.EventHandler(this.SoftwareLicenca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoftwareLicenca_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).EndInit();
            this.gpbLicenca.ResumeLayout(false);
            this.gpbLicenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSoftware;
        private System.Windows.Forms.GroupBox gpbLicenca;
        private System.Windows.Forms.DataGridView dgvLicenca;
        private System.Windows.Forms.Button btnAdicionarSoftware;
        private System.Windows.Forms.Button btnRemoverSoftware;
        private System.Windows.Forms.Button btnRemoverLicenca;
        private System.Windows.Forms.Button btnAdicionarLicenca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNfe;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox textBox2;
    }
}