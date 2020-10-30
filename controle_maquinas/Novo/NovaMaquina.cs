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
    public partial class NovaMaquina : Form
    {
        DBC CG = new DBC();

        public NovaMaquina()
        {
            InitializeComponent();
        }

        //Metodos
        private void AtualizarCbbSoftware()
        {
            //Limpa o cbb
            cbbSoftware.Items.Clear();

            //Adiciona o index 0
            cbbSoftware.Items.Add("Selecionar Software");
            cbbSoftware.SelectedIndex = 0;

            //Pesquisam os nome dos Software no banco de dados
            string cmd = "SELECT * FROM software WHERE nome not like 'Windows%';";
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
        private void AtualizarCbbOs()
        {
            //Limpa o cbb
            cbbOS.Items.Clear();

            cbbOS.Items.Add("Selecionar S.O");
            cbbOS.SelectedIndex = 0;

            //Pesquisam os nome dos Software no banco de dados
            string cmd = "SELECT * FROM software WHERE nome like 'Windows%';";
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
                cbbOS.Items.Add(Software);
            }
        }
        private void LimparForm()
        {
            txtDominio.Clear();
            txtMaquina.Clear();
            txtUser.Clear();
            txtProcessador.Clear();
            txtMemoria.Clear();
            txtArmazenamento.Clear();
            txtGpu.Clear();
            cbbOS.Items.Clear();
            cbbKeyOS.Items.Clear();
            txtObservacao.Clear();
            rdbComputador.Checked = true;
            cbbKey.Items.Clear();
            cbbSoftware.Items.Clear();
            dgvSoftware.Rows.Clear();
        }
        private void AtualizarForm()
        {
            LimparForm();

            cbbKey.Items.Clear();
            cbbKey.Items.Add("Selecionar licença");
            cbbKey.SelectedIndex = 0;
            cbbKeyOS.Items.Clear();
            cbbKeyOS.Items.Add("Selecionar licença");
            cbbKeyOS.SelectedIndex = 0;

            AtualizarCbbOs();
            AtualizarCbbSoftware();
        }

        //Form
        private void NovaMaquina_Load(object sender, EventArgs e)
        {
            //Remover linha em branco DataGridView
            dgvSoftware.AllowUserToAddRows = false;

            rdbComputador.Checked = true;
            AtualizarForm();
        }

        //ComboBox
        private void cbbSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Software = "";

            cbbKey.Items.Clear();
            cbbKey.Items.Add("Selecionar licença");
            cbbKey.SelectedIndex = 0;

            if (cbbSoftware.Text != "Selecionar Software")
            {
                Software = cbbSoftware.Text;
                string cmd = "SELECT * FROM software_licencas where software = '" + Software + "' and disponivel = 's';";
                CG.ExecutarComandoSql(cmd);

                //Declara um DataTable
                DataTable dt;
                //Instancia o DataTable e insere o retorno do banco de dados no mesmo
                dt = new DataTable();
                CG.RetornarDadosDataTable(dt);

                string Key = "";

                //Para Cada Software inserido no DataTable
                foreach (DataRow r in dt.Rows)
                {
                    //Retorna o nome do cliente na variável
                    Key = r[2].ToString();

                    //Insere o nome do cliente na ComboBox
                    cbbKey.Items.Add(Key);
                }
            }
            else
            {
                return;
            }
        }
        private void cbbOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Software = "";

            cbbKeyOS.Items.Clear();
            cbbKeyOS.Items.Add("Selecionar licença");
            cbbKeyOS.SelectedIndex = 0;

            if (cbbOS.Text != "Selecionar S.O")
            {
                Software = cbbOS.Text;
                string cmd = "SELECT * FROM software_licencas where software = '" + Software + "' and disponivel = 's';";
                CG.ExecutarComandoSql(cmd);

                //Declara um DataTable
                DataTable dt;
                //Instancia o DataTable e insere o retorno do banco de dados no mesmo
                dt = new DataTable();
                CG.RetornarDadosDataTable(dt);

                string Key = "";

                //Para Cada Software inserido no DataTable
                foreach (DataRow r in dt.Rows)
                {
                    //Retorna o nome do cliente na variável
                    Key = r[2].ToString();

                    //Insere o nome do cliente na ComboBox
                    cbbKeyOS.Items.Add(Key);
                }
            }
            else
            {
                return;
            }
        }

        //Botão
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string Verificar = "";
            string software = cbbSoftware.Text;
            string key = cbbKey.Text;

            if (cbbSoftware.Text == "Selecionar Software")
            {
                MessageBox.Show("Selecione um Software");
                return;
            }
            if (cbbKey.Text == "Selecionar licença")
            {
                MessageBox.Show("Selecione a key");
                return;
            }


            foreach (DataGridViewRow dgv in dgvSoftware.Rows)
            {
                Verificar = dgv.Cells[1].Value.ToString();

                if (key == Verificar)
                {
                    MessageBox.Show("Licença ja adicionada");
                    return;
                }

            }

            dgvSoftware.Rows.Add(software, key);

            cbbSoftware.SelectedIndex = 0;
            cbbKey.SelectedIndex = 0;

        }
        private void btnLimparSoftware_Click(object sender, EventArgs e)
        {
            dgvSoftware.Rows.Clear();
            cbbSoftware.SelectedIndex = 0;
            cbbKey.SelectedIndex = 0;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region Validaçao
            //Validação
            if (txtDominio.Text.Trim() == "")
            {
                MessageBox.Show("Informe o domínio!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtMaquina.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Nome da maquina!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Usuário real!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtProcessador.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Processador\nCaso não tenha Informe \"NA\" !", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtMemoria.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Memoria\nCaso não tenha Informe \"NA\" !", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtArmazenamento.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Armazenamento\nCaso não tenha Informe \"NA\" !", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtGpu.Text.Trim() == "")
            {
                MessageBox.Show("Informe a GPU\nCaso não tenha Informe \"NA\" !", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbbOS.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione o Sistema Operacional!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cbbKeyOS.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione a Key do Sistema Operacional!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            #region Variaveis
            //Comando Mysql
            string cmd = "";

            //Verificar
            string disponibilidade = "";

            //Maquina
            string Nome_Maquina = txtMaquina.Text;
            string Nome_Dominio = txtDominio.Text;
            string Nome_Usuario = txtUser.Text;
            string Id_Hardware = "";
            string Pc_Note = "";
            string Observacao = txtObservacao.Text;
            string SO = cbbOS.Text;
            string KeyOS = cbbKeyOS.Text;

            //Hardware
            string Processador = txtProcessador.Text;
            string Memoria = txtMemoria.Text;
            string Armazenamento = txtArmazenamento.Text;
            string Gpu = txtGpu.Text;
            //Pc ou Notebook
            if (rdbComputador.Checked == true)
            {
                Pc_Note = "pc";
            }
            if (rdbNotebook.Checked == true)
            {
                Pc_Note = "Notebook";
            }

            //Software
            string Id_Maquina = "";
            string Id_Licenca = "";
            #endregion

            #region HardWare
            //Salva Hardware e retorna o id
            cmd = "INSERT INTO `hardware` " +
                  "(`processador`, `memoria`, `armazenamento`, `gpu`) " +
                  "VALUES ('" + Processador + "', '" + Memoria + "', '" + Armazenamento + "', '" + Gpu + "');";
            CG.ExecutarComandoSql(cmd);

            //Pega id do hardware
            cmd = "select max(id) from hardware;";
            CG.ExecutarComandoSql(cmd);
            Id_Hardware = CG.RetornarValorSQL();
            #endregion

            #region Maquina
            //Salva Maquina
            cmd = "INSERT INTO `maquina` " +
                  "(`nome_maquina`, `nome_dominio`, `nome_usuario`, `id_hardware`, `pc_and_note`, `observacao`, `sistema_operacional`, `keyos`) " +
                  "VALUES ('" + Nome_Maquina + "', '" + Nome_Dominio + "', '" + Nome_Usuario + "', '" + Id_Hardware + "', '" + Pc_Note + "', '" + Observacao + "', '" + SO + "', '" + KeyOS + "');";
            CG.ExecutarComandoSql(cmd);

            //Marca licença Sistemo Operacional em uso
            cmd = "UPDATE `software_licencas` SET `disponivel` = 'n' WHERE (`key` = '" + KeyOS + "' and fpp = 's');";
            CG.ExecutarComandoSql(cmd);

            //Pega id da maquina
            cmd = "select max(id) from maquina;";
            CG.ExecutarComandoSql(cmd);
            Id_Maquina = CG.RetornarValorSQL();
            #endregion

            #region SoftWare
            //Verifica se o datagridview esta vazio
            if (dgvSoftware.RowCount != 0)
            {
                //Salvar Software
                foreach (DataGridViewRow dgv in dgvSoftware.Rows)
                {
                    //Pega a Key e software
                    string Software = dgv.Cells[0].Value.ToString();
                    string Licenca = dgv.Cells[1].Value.ToString();

                    //Pega id Da key
                    cmd = "SELECT id FROM software_licencas where `key` = '" + Licenca + "';";
                    CG.ExecutarComandoSql(cmd);
                    Id_Licenca = CG.RetornarValorSQL();

                    cmd = "SELECT disponivel FROM software_licencas where `id` = '" + Id_Licenca + "';";
                    CG.ExecutarComandoSql(cmd);
                    disponibilidade = CG.RetornarValorSQL();

                    if(disponibilidade == "s")
                    {
                        //Insere no banco de dados
                        cmd = "INSERT INTO `maquina_software` (`id_maquina`, `id_licenca`) VALUES ('" + Id_Maquina + "', '" + Id_Licenca + "');";
                        CG.ExecutarComandoSql(cmd);

                        //Marca Software em uso
                        cmd = "UPDATE `software_licencas` SET `disponivel` = 'n' WHERE (`id` = '" + Id_Licenca + "' and fpp = 's');";
                        CG.ExecutarComandoSql(cmd);
                    }
                    else
                    {
                        MessageBox.Show("Esta em Uso\n\n" + "Software: " + Software + "key: " + Licenca);                        
                    }                   
                }
            }
            #endregion

            AtualizarForm();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMaquina.Clear();
            txtDominio.Clear();
            txtUser.Clear();
            txtObservacao.Clear();
            cbbOS.Items.Clear();
            cbbKeyOS.Items.Clear();
            txtProcessador.Clear();
            txtMemoria.Clear();
            txtArmazenamento.Clear();
            txtGpu.Clear();
            rdbComputador.Checked = true;

            AtualizarForm();

        }
    }
}

