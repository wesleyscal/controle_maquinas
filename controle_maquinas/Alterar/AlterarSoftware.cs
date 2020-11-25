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
    public partial class Software : Form
    {
        DBC CG = new DBC();
        string AntigoOs = "";
        string AntigoSoftware = "";

        public Software()
        {
            InitializeComponent();
        }

        private void Software_Load(object sender, EventArgs e)
        {
            if (SoftwareLicenca.IdSoftware != "")
            {
                foreach (DataRow r in SoftwareLicenca.AltSoftware.Rows)
                {
                    AntigoOs = r[2].ToString();
                    AntigoSoftware = r[1].ToString();
                    txtNome.Text = r[1].ToString();

                    if (AntigoOs == "s")
                    {
                        ckbOs.Checked = true;
                    }
                    if (AntigoOs == "n")
                    {
                        ckbOs.Checked = false;
                    }
                }
            }

            txtNome.Select();
        }
        private void AlterarSoftware_KeyDown(object sender, KeyEventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Campo Software vazio");
                return;
            }

            //Datatable licenca
            DataTable id = new DataTable();

            string cmd = "";
            string NovoOs = "";
            string NovoNome = txtNome.Text;
            string licenca = "";

            if (ckbOs.Checked == true)
            {
                NovoOs = "s";
            }
            if (ckbOs.Checked == false)
            {
                NovoOs = "n";
            }

            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Salvar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }

            //Salvar
            if (SoftwareLicenca.IdSoftware == "")
            {
                string SavSoftware = txtNome.Text;
                string os = "";

                if (ckbOs.Checked == true)
                {
                    os = "s";
                }
                if (ckbOs.Checked == false)
                {
                    os = "n";
                }

                cmd = "INSERT INTO `software` (`nome`,`os`) VALUES ('" + SavSoftware + "','" + os + "');";
                CG.ExecutarComandoSql(cmd);
            }

            //Alterar
            if (SoftwareLicenca.IdSoftware != "")
            {

                //Verifica se teve alteração na CheckBox
                if (AntigoOs != NovoOs)
                {
                    //Reinicia as licencas
                    cmd = "UPDATE `software_licencas` SET `qtd` = qtdmax WHERE (`software` = '" + AntigoSoftware + "');";
                    CG.ExecutarComandoSql(cmd);

                    //De OS para Software
                    if (NovoOs == "n")
                    {
                        //Marca Como Não OS
                        cmd = "UPDATE `software` SET `os` = 'n' WHERE (`nome` = '" + AntigoSoftware + "');";
                        CG.ExecutarComandoSql(cmd);

                        //Remove de Maquina
                        cmd = "UPDATE `maquina` SET `sistema_operacional` = '', `keyos` = '' WHERE (`sistema_operacional` = '" + AntigoSoftware + "');";
                        CG.ExecutarComandoSql(cmd);

                    }
                    //De Software Para OS
                    if (NovoOs == "s")
                    {
                        //Marca Como OS
                        cmd = "UPDATE `software` SET `os` = 's' WHERE (`nome` = '" + AntigoSoftware + "');";
                        CG.ExecutarComandoSql(cmd);


                        //Pega os Id da licençã e coloca no DataTable
                        cmd = "SELECT id FROM software_licencas WHERE software = '" + AntigoSoftware + "';";
                        CG.ExecutarComandoSql(cmd);
                        CG.RetornarDadosDataTable(id);

                        //Exclui os Software da Maquina_Software
                        foreach (DataRow r in id.Rows)
                        {
                            licenca = r[0].ToString();

                            cmd = "DELETE FROM `maquina_software` WHERE (`id_licenca` = '" + licenca + "');";
                            CG.ExecutarComandoSql(cmd);
                        }
                    }

                }

                //Aletra o nome no Software
                cmd = "UPDATE software SET `nome` = '" + NovoNome + "' WHERE (`nome` = '" + AntigoSoftware + "');";
                CG.ExecutarComandoSql(cmd);

                //Altera o nome nas licencas
                cmd = "UPDATE `software_licencas` SET `software` = '" + NovoNome + "' WHERE (`software` = '" + AntigoSoftware + "');";
                CG.ExecutarComandoSql(cmd);

                SoftwareLicenca.AltSoftware.Clear();
            }

            Close();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
