using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_maquinas
{
    public partial class NovoSoftware : Form
    {
        public NovoSoftware()
        {
            InitializeComponent();
        }

        private void NovoSoftware_Load(object sender, EventArgs e)
        {
            txtSoftware.Visible = false;
        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            if(btnSoftware.Text == "Selecionar Software")
            {
                
                txtSoftware.Visible = false;
                cbbSoftware.Visible = true;
                btnSoftware.Text = "Novo Software";
                btnSaveClear.Text = "Limpar";
                return;
            }
            if (btnSoftware.Text == "Novo Software")
            {
                cbbSoftware.Visible = false;
                txtSoftware.Visible = true;
                btnSoftware.Text = "Selecionar Software";
                btnSaveClear.Text = "Salvar";
                return;                
            }
        }

        private void btnSaveClear_Click(object sender, EventArgs e)
        {
            if(btnSaveClear.Text == "Limpar")
            {
                cbbSoftware.SelectedIndex = 0;
                txtSoftware.Clear();
            }
            if(btnSaveClear.Text == "Salvar")
            {

            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {

        }
    }
}
