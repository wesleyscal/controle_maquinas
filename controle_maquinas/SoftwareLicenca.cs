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
using System.Text.RegularExpressions;

namespace controle_maquinas
{
    public partial class SoftwareLicenca : Form
    {
        DBC CG = new DBC();

        public SoftwareLicenca()
        {
            InitializeComponent();
        }

        public static DataTable AltSoftware = new DataTable();

        public static string AlterarLicenca = "";

        //Metodos
        private void CarregarDGV()
        {
            string cmd = "SELECT id, nome 'Nome', os 'OS' FROM software;";
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
            if (dgvSoftware.CurrentRow != null)
            {
                string id = dgvSoftware.CurrentRow.Cells[0].Value.ToString(); ;

                string cmd = "SELECT * FROM software where id = " + id + ";";
                CG.ExecutarComandoSql(cmd);
                CG.RetornarDadosDataTable(AltSoftware);

                AlterarSoftware frm = new AlterarSoftware();
                frm.ShowDialog();

                CarregarDGV();
            }
            else
            {
                MessageBox.Show("Selecione um Software");
            }

        }
        private void btnRemoverSoftware_Click(object sender, EventArgs e)
        {
            //Variaveis
            string Id_Software = dgvSoftware.CurrentRow.Cells[0].Value.ToString();
            string Software = dgvSoftware.CurrentRow.Cells[1].Value.ToString(); ;
            string licenca = "";
            string os = "";
            string cmd = "";

            //Datatable licenca
            DataTable id = new DataTable();

            //Confirma se Deseja Fazer a excluxão
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

            //Pega os Id da licençã e coloca no DataTable
            cmd = "SELECT id FROM software_licencas WHERE software = '" + Software + "';";
            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(id);

            //Pega se é Os ou não
            cmd = "SELECT os FROM software where id = '" + Id_Software + "';";
            CG.ExecutarComandoSql(cmd);
            os = CG.RetornarValorSQL();

            //Exclui os Software da Maquina_Software
            foreach (DataRow r in id.Rows)
            {
                licenca = r[0].ToString();

                cmd = "DELETE FROM `maquina_software` WHERE (`id_licenca` = '" + licenca + "');";
                CG.ExecutarComandoSql(cmd);
            }

            //Exclui o Software
            cmd = "DELETE FROM `software` WHERE (`id` = '" + Id_Software + "');";
            CG.ExecutarComandoSql(cmd);

            //Exclui A licenca
            cmd = "DELETE FROM `software_licencas` WHERE (`software` = '" + Software + "');";
            CG.ExecutarComandoSql(cmd);

            //Se for OS remove de maquina
            if (os == "s")
            {
                cmd = "UPDATE `maquina` SET `sistema_operacional` = '', `keyos` = '' WHERE (`sistema_operacional` = '" + Software + "');";
                CG.ExecutarComandoSql(cmd);
            }

            CarregarDGV();

        }
        private void btnAlterarLicenca_Click(object sender, EventArgs e)
        {
            AlterarLicencas();
        }
        private void btnRemoverLicenca_Click(object sender, EventArgs e)
        {
            if (dgvLicenca.CurrentRow != null)
            {
                string info = dgvLicenca.CurrentRow.Cells[1].Value.ToString();
                //Confirma se Deseja Fazer a excluxão
                DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Apagar " + info + " !", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() != "YES")
                {
                    return;
                }

                string licenca = dgvLicenca.CurrentRow.Cells[0].Value.ToString();
                string cmd = "";

                cmd = "DELETE FROM `software_licencas` WHERE (`id` = '" + licenca + "');";
                CG.ExecutarComandoSql(cmd);

                cmd = "DELETE FROM `maquina_software` WHERE (`id_licenca` = '" + licenca + "');";
                CG.ExecutarComandoSql(cmd);

                CarregarDGV();
            }
            else
            {
                MessageBox.Show("Selecione uma licença");
            }
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string Key = txtKey.Text.Trim();
            string Nfe = txtNfe.Text.Trim();
            string cmd = "";

            if (Key == "" && Nfe == "")
            {
                MessageBox.Show("Os campos de pesquisa estão vazio");
                return;
            }

            gpbLicenca.Text = "Resultado da Pesquisa !";

            if (Key != "")
            {
                Key = "%" + Key + "%";
            }
            if (Nfe != "")
            {
                Nfe = "%" + Nfe + "%";
            }

            if (Key == "" && Nfe != "")
            {
                cmd = "SELECT id 'id', " +
                        "software 'Software', " +
                        "`key` 'Key'," +
                        "nfe 'NFe'," +
                        "qtd 'Quantidade Livre'," +
                        "qtdmax 'Quantidade Total'," +
                        " observacao 'Observação' " +
                        "FROM " +
                        "software_licencas " +
                        "where `nfe` like '" + Nfe + "';";
            }
            if (Nfe == "" && Key != "")
            {
                cmd = "SELECT id 'id'," +
                       "software 'Software', " +
                       "`key` 'Key'," +
                       "nfe 'NFe'," +
                       "qtd 'Quantidade Livre'," +
                       "qtdmax 'Quantidade Total'," +
                       " observacao 'Observação' " +
                       "FROM " +
                       "software_licencas " +
                       "where `key` like '" + Key + "';";
            }
            if (Nfe != "" && Key != "")
            {
                cmd = "SELECT id 'id'," +
                      "software 'Software', " +
                       "`key` 'Key'," +
                       "nfe 'NFe'," +
                       "qtd 'Quantidade Livre'," +
                       "qtdmax 'Quantidade Total'," +
                       " observacao 'Observação' " +
                       "FROM " +
                       "software_licencas " +
                       "where `key` like '" + Key + "' or `nfe` like '" + Nfe + "';";
            }


            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvLicenca);
            dgvLicenca.Columns[0].Visible = false;
        }

        //DataGridView
        private void dgvSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string software = dgvSoftware.CurrentRow.Cells[1].Value.ToString();

            string cmd = "SELECT id 'id'," +
                         "`key` 'Key'," +
                         "nfe 'NFe'," +
                         "qtd 'Quantidade Livre'," +
                         "qtdmax 'Quantidade Total'," +
                         " observacao 'Observação' " +
                         "FROM " +
                         "software_licencas " +
                         "where software = '" + software + "';";

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
