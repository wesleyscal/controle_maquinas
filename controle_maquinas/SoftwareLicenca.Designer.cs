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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSoftware = new System.Windows.Forms.DataGridView();
            this.dgvLicenca = new System.Windows.Forms.DataGridView();
            this.btnAlterarSoftware = new System.Windows.Forms.Button();
            this.btnRemoverSoftware = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoverSoftware);
            this.groupBox1.Controls.Add(this.btnAlterarSoftware);
            this.groupBox1.Controls.Add(this.dgvSoftware);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Software";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgvLicenca);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Licença";
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoftware.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoftware.Location = new System.Drawing.Point(6, 19);
            this.dgvSoftware.Name = "dgvSoftware";
            this.dgvSoftware.ReadOnly = true;
            this.dgvSoftware.Size = new System.Drawing.Size(651, 153);
            this.dgvSoftware.TabIndex = 0;
            this.dgvSoftware.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoftware_CellDoubleClick);
            // 
            // dgvLicenca
            // 
            this.dgvLicenca.AllowUserToAddRows = false;
            this.dgvLicenca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvLicenca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLicenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLicenca.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLicenca.Location = new System.Drawing.Point(6, 19);
            this.dgvLicenca.Name = "dgvLicenca";
            this.dgvLicenca.ReadOnly = true;
            this.dgvLicenca.Size = new System.Drawing.Size(651, 216);
            this.dgvLicenca.TabIndex = 1;
            // 
            // btnAlterarSoftware
            // 
            this.btnAlterarSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterarSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSoftware.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSoftware.ForeColor = System.Drawing.Color.Gold;
            this.btnAlterarSoftware.Location = new System.Drawing.Point(663, 19);
            this.btnAlterarSoftware.Name = "btnAlterarSoftware";
            this.btnAlterarSoftware.Size = new System.Drawing.Size(107, 73);
            this.btnAlterarSoftware.TabIndex = 30;
            this.btnAlterarSoftware.Text = "Alterar Software";
            this.btnAlterarSoftware.UseVisualStyleBackColor = false;
            this.btnAlterarSoftware.Click += new System.EventHandler(this.btnAlterarSoftware_Click);
            // 
            // btnRemoverSoftware
            // 
            this.btnRemoverSoftware.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoverSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverSoftware.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverSoftware.ForeColor = System.Drawing.Color.Gold;
            this.btnRemoverSoftware.Location = new System.Drawing.Point(663, 98);
            this.btnRemoverSoftware.Name = "btnRemoverSoftware";
            this.btnRemoverSoftware.Size = new System.Drawing.Size(107, 73);
            this.btnRemoverSoftware.TabIndex = 31;
            this.btnRemoverSoftware.Text = "Remover Software";
            this.btnRemoverSoftware.UseVisualStyleBackColor = false;
            this.btnRemoverSoftware.Click += new System.EventHandler(this.btnRemoverSoftware_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(663, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 73);
            this.button1.TabIndex = 33;
            this.button1.Text = "Remover licença";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(663, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 73);
            this.button2.TabIndex = 32;
            this.button2.Text = "Alterar Licença";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SoftwareLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SoftwareLicenca";
            this.Text = "Software e Licenca";
            this.Load += new System.EventHandler(this.SoftwareLicenca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSoftware;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLicenca;
        private System.Windows.Forms.Button btnAlterarSoftware;
        private System.Windows.Forms.Button btnRemoverSoftware;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}