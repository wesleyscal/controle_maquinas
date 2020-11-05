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
        public static string AlterarLicenca = "";

        //Metodos
        private void CarregarDGV()
        {
            string cmd = "SELECT id, nome 'Nome' FROM software;";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvSoftware);
            dgvSoftware.Columns[0].Visible = false;
            if (dgvLicenca.RowCount != 0)
            {
                dgvLicenca.DataSource = null;
            }

            gpbLicenca.Text = "Licença";

        }
        private void AlterarLicencas()
        {
            if (dgvLicenca.CurrentRow != null)
            {
                AlterarLicenca = dgvLicenca.CurrentRow.Cells[0].Value.ToString();

                AlterarLicenca frm = new AlterarLicenca();
                frm.ShowDialog();

                CarregarDGV();
            }
            else
            {
                MessageBox.Show("Selecione uma licença");
            }
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
            string Software = dgvSoftware.CurrentRow.Cells[1].Value.ToString(); ;
            string licenca = "";
            string cmd = "";

            DataTable id = new DataTable();

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Apagar " + Software + " !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }

            DialogResult confirm2 = MessageBox.Show("Deseja Continuar ?\n\nIsso Apagara Todas as licenças referente a " + Software + " !", "Apagar Todos as Licença", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm2.ToString().ToUpper() != "YES")
            {
                return;
            }

            cmd = "SELECT id FROM software_licencas WHERE software = '" + Software + "';";
            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(id);

            foreach (DataRow r in id.Rows)
            {
                licenca = r[0].ToString();

                cmd = "DELETE FROM `maquina_software` WHERE (`id_licenca` = '" + licenca + "');";
                CG.ExecutarComandoSql(cmd);
            }

            cmd = "DELETE FROM `software` WHERE (`id` = '" + Id_Software + "');";
            CG.ExecutarComandoSql(cmd);

            cmd = "DELETE FROM `software_licencas` WHERE (`software` = '" + Software + "');";
            CG.ExecutarComandoSql(cmd);            
            
            CarregarDGV();

        }
        private void btnAlterarLicenca_Click(object sender, EventArgs e)
        {
            AlterarLicencas();
        }
        private void btnRemoverLicenca_Click(object sender, EventArgs e)
        {
            string licenca = dgvLicenca.CurrentRow.Cells[0].Value.ToString();
            string cmd = "";

            cmd = "DELETE FROM `software_licencas` WHERE (`id` = '" + licenca + "');";
            CG.ExecutarComandoSql(cmd);

            CarregarDGV();

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
        private void dgvLicenca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarLicencas();
        }
    }
}
