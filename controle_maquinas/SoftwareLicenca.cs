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
    public partial class SoftwareLicenca : Form
    {
        DBC CG = new DBC();
         
        public SoftwareLicenca()
        {
            InitializeComponent();
        }

        public static string AltearaSoftware = "";

        //Metodos
        private void CarregarDGV()
        {
            string cmd = "SELECT id, nome 'Nome' FROM software;";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvSoftware);
            dgvSoftware.Columns[0].Visible = false;

        }

        //Form
        private void SoftwareLicenca_Load(object sender, EventArgs e)
        {
            CarregarDGV();
            CG.FormatarDGV(dgvSoftware);
            CG.FormatarDGV(dgvLicenca);
        }


        //Botão
        private void btnAlterarSoftware_Click(object sender, EventArgs e)
        {
            AltearaSoftware = dgvSoftware.CurrentRow.Cells[1].Value.ToString();

            AlterarSoftware frm = new AlterarSoftware();
            frm.ShowDialog();

            CarregarDGV();
        }
        private void btnRemoverSoftware_Click(object sender, EventArgs e)
        {
            string Id_Software = dgvSoftware.CurrentRow.Cells[0].Value.ToString();
            string Id_Licenca = "";
            string cmd = "";

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Apagar Software", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }

            DialogResult confirm2 = MessageBox.Show("Deseja Continuar ?\nIsso Apagara Todas as licenças referente a esse Software", "Apagar Todos as Licença", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm2.ToString().ToUpper() != "YES")
            {
                return;
            }

            cmd = "DELETE FROM `software` WHERE (`id` = '1');";

        }


        //DataGridView
        private void dgvSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string software = dgvSoftware.CurrentRow.Cells[1].Value.ToString();

            string cmd = "SELECT id 'id',`key` 'Key',nfe 'NFe',fpp 'licença FPP',disponivel 'Disponivel', observacao 'Observação' FROM software_licencas where software = '" + software + "';";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvLicenca);
            dgvLicenca.Columns[0].Visible = false;
            gpbLicenca.Text = "Licenças " + software;
        }
    }
}
