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
                string cmd = "INSERT INTO `software` (`nome`) VALUES ('" + SavSoftware + "');";
                CG.ExecutarComandoSql(cmd);

                Close();
            }
            else
            {
                MessageBox.Show("Campo Software vazio");
            }
        }
    }
}
