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

        private void CarregarDGV()
        {
            string cmd = "SELECT id, nome 'Nome' FROM software;";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvSoftware);
            dgvSoftware.Columns[0].Visible = false;

        }

        private void SoftwareLicenca_Load(object sender, EventArgs e)
        {
            CarregarDGV();
            CG.FormatarDGV(dgvSoftware);
            CG.FormatarDGV(dgvLicenca);
        }

        private void dgvSoftware_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string software = dgvSoftware.CurrentRow.Cells[1].Value.ToString();

            string cmd = "SELECT id 'id',`key` 'Key',nfe 'NFe',fpp 'licença FPP',disponivel 'Disponivel', observacao 'Observação' FROM software_licencas where software = '" + software + "';";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvLicenca);
            dgvLicenca.Columns[0].Visible = false;
        }

        private void btnAlterarSoftware_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverSoftware_Click(object sender, EventArgs e)
        {

        }
    }
}
