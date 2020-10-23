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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoftware = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.btnHardware = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnNovoSoftware = new System.Windows.Forms.Button();
            this.btnNovaMaquina = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoftware);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaquina);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Gold;
            this.btnPesquisar.Location = new System.Drawing.Point(310, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(107, 41);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Software";
            // 
            // txtSoftware
            // 
            this.txtSoftware.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoftware.Location = new System.Drawing.Point(158, 36);
            this.txtSoftware.Name = "txtSoftware";
            this.txtSoftware.Size = new System.Drawing.Size(146, 21);
            this.txtSoftware.TabIndex = 2;
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
            this.txtMaquina.Size = new System.Drawing.Size(146, 21);
            this.txtMaquina.TabIndex = 0;
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Location = new System.Drawing.Point(13, 85);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.Size = new System.Drawing.Size(777, 439);
            this.dgvMaquinas.TabIndex = 1;
            // 
            // btnHardware
            // 
            this.btnHardware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardware.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardware.ForeColor = System.Drawing.Color.Gold;
            this.btnHardware.Location = new System.Drawing.Point(232, 16);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Size = new System.Drawing.Size(107, 41);
            this.btnHardware.TabIndex = 2;
            this.btnHardware.Text = "Novo hardware";
            this.btnHardware.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 530);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(803, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "|| F1 - Faz alguma coisa ||";
            // 
            // btnNovoSoftware
            // 
            this.btnNovoSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovoSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoSoftware.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoSoftware.ForeColor = System.Drawing.Color.Gold;
            this.btnNovoSoftware.Location = new System.Drawing.Point(119, 16);
            this.btnNovoSoftware.Name = "btnNovoSoftware";
            this.btnNovoSoftware.Size = new System.Drawing.Size(107, 41);
            this.btnNovoSoftware.TabIndex = 3;
            this.btnNovoSoftware.Text = "Novo Software";
            this.btnNovoSoftware.UseVisualStyleBackColor = false;
            this.btnNovoSoftware.Click += new System.EventHandler(this.btnNovoSoftware_Click);
            // 
            // btnNovaMaquina
            // 
            this.btnNovaMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovaMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaMaquina.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaMaquina.ForeColor = System.Drawing.Color.Gold;
            this.btnNovaMaquina.Location = new System.Drawing.Point(6, 16);
            this.btnNovaMaquina.Name = "btnNovaMaquina";
            this.btnNovaMaquina.Size = new System.Drawing.Size(107, 41);
            this.btnNovaMaquina.TabIndex = 4;
            this.btnNovaMaquina.Text = " Nova  Maquina";
            this.btnNovaMaquina.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHardware);
            this.groupBox2.Controls.Add(this.btnNovoSoftware);
            this.groupBox2.Controls.Add(this.btnNovaMaquina);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(444, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(802, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvMaquinas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle De Maquinas";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnHardware;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoSoftware;
        private System.Windows.Forms.Button btnNovaMaquina;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoftware;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

