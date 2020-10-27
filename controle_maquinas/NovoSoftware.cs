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

        //Metodos
        private void ConfigCBB()
        {
            cbbSoftware.Items.Clear();

            cbbSoftware.Items.Add("Selecionar Software");
            cbbSoftware.SelectedIndex = 0;

            //Pesquisam os nome dos Software no banco de dados
            string cmd = "SELECT * FROM controle_maquina.software;";
            CG.ExecutarComandoSql(cmd);

            //Declara um DataTable
            DataTable dt;
            //Instancia o DataTable e insere o retorno do banco de dados no mesmo
            dt = new DataTable();
            CG.RetornarDadosDataTable(dt);

            string Software = "";

            //Para Cada Software inserido no DataTable
            foreach (DataRow r in dt.Rows)
            {
                //Retorna o nome do cliente na variável
                Software = r[1].ToString();

                //Insere o nome do cliente na ComboBox
                cbbSoftware.Items.Add(Software);
            }
        }

        //Form
        private void NovoSoftware_Load(object sender, EventArgs e)
        {
            txtSoftware.Visible = false;
            ConfigCBB();
        }

        //Botao
        private void btnSoftware_Click(object sender, EventArgs e)
        {
            if (btnSoftware.Text == "Selecionar Software")
            {
                txtSoftware.Visible = false;
                cbbSoftware.Visible = true;
                btnSoftware.Text = "Novo Software";
                btnSaveDel.Text = "Deletar";
                cbbSoftware.SelectedIndex = 0;
                txtSoftware.Clear();
                return;
            }
            if (btnSoftware.Text == "Novo Software")
            {
                cbbSoftware.Visible = false;
                txtSoftware.Visible = true;
                btnSoftware.Text = "Selecionar Software";
                btnSaveDel.Text = "Salvar";
                txtSoftware.Clear();
                cbbSoftware.SelectedIndex = 0;
                return;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtNfe.Clear();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbbSoftware.Text != "Selecionar Software")
            {
                if (txtKey.Text.Trim() != "")
                {
                    if (txtNfe.Text.Trim() != "")
                    {
                        string Software = cbbSoftware.Text;
                        string Key = txtKey.Text;
                        string nfe = txtNfe.Text;
                        string observacao = txtObservacao.Text;
                        string licenca = "";

                        if (rdbUnica.Checked == true)
                        {
                            licenca = "s";
                        }
                        if (rdbMultiplas.Checked == true)
                        {
                            licenca = "n";
                        }

                        string cmd = "INSERT INTO `software_licencas` (`software`, `key`, `nfe`, `fpp`, `disponivel`, `observacao`) VALUES ('" + Software + "', '" + Key + "', '" + nfe + "', '" + licenca + "', '" + "s" + "', '" + observacao + "');";
                        CG.ExecutarComandoSql(cmd);

                        txtSoftware.Clear();
                        txtKey.Clear();
                        txtNfe.Clear();
                        txtObservacao.Clear();
                        cbbSoftware.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Campo NF-e vazio");
                    }
                }
                else
                {
                    MessageBox.Show("Campo Key vazio");
                }
            }
            else
            {
                MessageBox.Show("Software Não Selecionado");
            }
        }
        private void btnSaveDel_Click(object sender, EventArgs e)
        {

            if (btnSaveDel.Text == "Deletar")
            {
                string DelSoftware = cbbSoftware.Text;

                DialogResult res = MessageBox.Show("Tem certeza que quer excluir " + DelSoftware + " ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    string dcmd = "delete FROM controle_maquina.software where nome = '" + DelSoftware + "';";
                    CG.ExecutarComandoSql(dcmd);
                }

                ConfigCBB();
                cbbSoftware.SelectedIndex = 0;
            }
            if (btnSaveDel.Text == "Salvar")
            {
                if (txtSoftware.Text.Trim() != "")
                {
                    string SavSoftware = txtSoftware.Text;
                    string cmd = "INSERT INTO `software` (`nome`) VALUES ('" + SavSoftware + "');";
                    CG.ExecutarComandoSql(cmd);

                    ConfigCBB();
                    txtSoftware.Visible = false;
                    cbbSoftware.Visible = true;
                    btnSoftware.Text = "Novo Software";
                    btnSaveDel.Text = "Deletar";
                    cbbSoftware.SelectedIndex = 0;

                    return;
                }
                else
                {
                    MessageBox.Show("Campo Software vazio");
                }

            }

        }

    }
}