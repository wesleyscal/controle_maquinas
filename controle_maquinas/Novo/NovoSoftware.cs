using Fd_DBC;
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
        DBC CG = new DBC();

        public NovoSoftware()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSoftware.Text.Trim() != "")
            {
                string SavSoftware = txtSoftware.Text;
                string os = "";

                if (ckbOs.Checked == true)
                {
                    os = "s";
                }
                if (ckbOs.Checked == false)
                {
                    os = "n";
                }

                string cmd = "INSERT INTO `software` (`nome`,`os`) VALUES ('" + SavSoftware + "','" + os + "');";
                CG.ExecutarComandoSql(cmd);

                Close();
            }
            else
            {
                MessageBox.Show("Campo Software vazio");
            }
        }

        private void NovoSoftware_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void NovoSoftware_Load(object sender, EventArgs e)
        {
            txtSoftware.Select();
        }
    }
}
