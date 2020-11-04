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
    public partial class AlterarSoftware : Form
    {
        DBC CG = new DBC();

        public AlterarSoftware()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlterarSoftware_Load(object sender, EventArgs e)
        {
            txtNome.Text = SoftwareLicenca.AltearaSoftware;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string NovoNome = txtNome.Text;

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Salvar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }

            string cmd = "UPDATE software SET `nome` = '" + NovoNome + "' WHERE (`nome` = '" + SoftwareLicenca.AltearaSoftware + "');";
            CG.ExecutarComandoSql(cmd);

            cmd = "UPDATE `software_licencas` SET `software` = '" + NovoNome + "' WHERE (`software` = '" + SoftwareLicenca.AltearaSoftware + "');";
            CG.ExecutarComandoSql(cmd);

            Close();
        }
    }
}
