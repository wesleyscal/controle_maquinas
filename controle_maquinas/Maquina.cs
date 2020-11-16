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
    public partial class Maquina : Form
    {
        DBC CG = new DBC();

        //Variaveis Form
        string OSAntiga = "";
        string KeyOSAntiga = "";
        string Id_Maquina = "";
        string Id_hardware = "";

        public Maquina()
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
            string cmd = "SELECT * FROM software WHERE os = 'n';";
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
                //Retorna o nome do Software na variável
                Software = r[1].ToString();

                //Insere o nome do Software na ComboBox
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
            string cmd = "SELECT * FROM software WHERE os = 's';";
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
        private void CarregarInformacoesPesquisa()
        {
            //Declara os DataTable
            DataTable Dt_Maquina = new DataTable();
            DataTable Dt_Software = new DataTable();

            //Variaveis
            string cmd = "";
            string PcNote = "";
            string Id_Software = "";
            string Software = "";
            string KeySoftware = "";
            string CBBOS = "";

            //Se o retorno for null Fecha o forme
            if (Form1.dt.Rows.Count == 0)
            {
                Close();
            }

            //Preenche Maquina e Sistemo Operacional
            foreach (DataRow r in Form1.dt.Rows)
            {
                Id_Maquina = r[0].ToString();
                txtMaquina.Text = r[1].ToString();
                txtDominio.Text = r[2].ToString();
                txtUser.Text = r[3].ToString();
                Id_hardware = r[4].ToString();
                PcNote = r[5].ToString();
                txtObservacao.Text = r[6].ToString();
                CBBOS = r[7].ToString();

                if (CBBOS != "")
                {
                    cbbOS.SelectedItem = CBBOS;
                }
                else
                {
                    cbbOS.SelectedIndex = 0;
                }
                OSAntiga = r[7].ToString();
                KeyOSAntiga = r[8].ToString();
            }

            cbbKeyOS.SelectedItem = KeyOSAntiga;

            if (cbbKeyOS.Text != KeyOSAntiga)
            {
                cbbKeyOS.Items.Add(KeyOSAntiga);
                cbbKeyOS.SelectedItem = KeyOSAntiga;
            }

            if (PcNote == "pc")
            {
                rdbComputador.Checked = true;
            }
            if (PcNote == "Notebook")
            {
                rdbNotebook.Checked = true;
            }

            //Preenche hardware
            cmd = "SELECT * FROM hardware where id = " + Id_hardware + ";";
            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(Dt_Maquina);
            foreach (DataRow r in Dt_Maquina.Rows)
            {
                txtProcessador.Text = r[1].ToString();
                txtMemoria.Text = r[2].ToString();
                txtArmazenamento.Text = r[3].ToString();
                txtGpu.Text = r[4].ToString();
            }

            //Limpa o DataTable
            Dt_Maquina.Rows.Clear();
            Dt_Maquina.Columns.Clear();

            //Pega os Id do Software
            cmd = "SELECT id_licenca FROM maquina_software where id_maquina = " + Id_Maquina + ";";
            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(Dt_Maquina);

            //Preenche Software
            foreach (DataRow r in Dt_Maquina.Rows)
            {
                Id_Software = r[0].ToString();
                Software = "";
                KeySoftware = "";

                cmd = "SELECT software, `key` FROM software_licencas where id = " + Id_Software + ";";
                CG.ExecutarComandoSql(cmd);
                CG.RetornarDadosDataTable(Dt_Software);

                //Adicona os software no datagridview
                foreach (DataRow r2 in Dt_Software.Rows)
                {
                    Software = r2[0].ToString();
                    KeySoftware = r2[1].ToString();
                }

                Dt_Software.Rows.Clear();
                dgvSoftware.Rows.Add(Software, KeySoftware);
            }
        }

        //Form
        private void NovaMaquina_Load(object sender, EventArgs e)
        {
            //Formata DGV
            CG.FormatarDGV(dgvSoftware);

            //Remover linha em branco DataGridView
            dgvSoftware.AllowUserToAddRows = false;
            dgvSoftware.AllowUserToDeleteRows = false;

            AtualizarForm();
            CarregarInformacoesPesquisa();

            //texto do form
            Text = txtMaquina.Text;
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
                string cmd = "SELECT * FROM software_licencas where software = '" + Software + "' and qtd > 0;";
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
                string cmd = "SELECT * FROM software_licencas where software = '" + Software + "' and qtd > '0';";
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

            foreach (var cbb in cbbKeyOS.Items)
            {
                cbbKeyOS.SelectedItem = cbb;

                if (cbbKeyOS.Text == KeyOSAntiga)
                {
                    cbbKeyOS.SelectedItem = KeyOSAntiga;
                    return;
                }
            }

            if (cbbOS.Text == OSAntiga)
            {
                cbbKeyOS.Items.Add(KeyOSAntiga);
                cbbKeyOS.SelectedItem = KeyOSAntiga;
            }
            else
            {
                cbbKeyOS.SelectedIndex = 0;
            }
        }

        //Botão
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string VerificarKey = "";
            string VerificarSoft = "";
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
                VerificarKey = dgv.Cells[1].Value.ToString();
                VerificarSoft = dgv.Cells[0].Value.ToString();

                if (software == VerificarSoft)
                {
                    if (key == VerificarKey)
                    {
                        MessageBox.Show("Licença ja adicionada");
                        return;
                    }
                }

            }

            dgvSoftware.Rows.Add(software, key);

            cbbSoftware.SelectedIndex = 0;
            cbbKey.SelectedIndex = 0;
        }
        private void btnLimparSoftware_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Remover todos os software?", "Limpar Software", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }

            dgvSoftware.Rows.Clear();
            cbbSoftware.SelectedIndex = 0;
            cbbKey.SelectedIndex = 0;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Fechar ?\nTodas as alterações serão perdidas !", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }
            Close();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvSoftware.RowCount == 0)
            {
                MessageBox.Show("Não a Licenca");
                return;
            }

            dgvSoftware.Rows.RemoveAt(dgvSoftware.CurrentRow.Index);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Salvar alterações", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }

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
            DataTable Dt_Software = new DataTable();

            //Comando Mysql
            string cmd = "";

            //Verificar
            int disponibilidade = 0;

            //Maquina
            string Nome_Maquina = txtMaquina.Text;
            string Nome_Dominio = txtDominio.Text;
            string Nome_Usuario = txtUser.Text;
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
            string Id_Software = "";
            #endregion

            #region HardWare
            //Update Hardware
            cmd = "UPDATE `hardware` " +
                  "SET `processador` = '" + Processador + "', `memoria` = '" + Memoria + "', `armazenamento` = '" + Armazenamento + "', `gpu` = '" + Gpu + "' " +
                  "WHERE `id` = '" + Id_hardware + "';";
            CG.ExecutarComandoSql(cmd);
            #endregion

            #region Maquina
            //Libera a Key se for alterada
            if (KeyOSAntiga != KeyOS)
            {
                //Marca OS como disponivel
                cmd = "UPDATE `software_licencas` SET `qtd` = qtd + 1 WHERE (`key` = '" + KeyOSAntiga + "');";
                CG.ExecutarComandoSql(cmd);
            }

            //Salva Maquina
            cmd = "UPDATE `maquina` " +
                  "SET `nome_maquina` = '" + Nome_Maquina + "', " +
                  "`nome_dominio` = '" + Nome_Dominio + "', " +
                  "`nome_usuario` = '" + Nome_Usuario + "', " +
                  "`pc_and_note` = '" + Pc_Note + "', " +
                  "`observacao` = '" + Observacao + "', " +
                  "`sistema_operacional` = '" + SO + "', " +
                  "`keyos` = '" + KeyOS + "' " +
                  "WHERE (`id` = '" + Id_Maquina + "');";
            CG.ExecutarComandoSql(cmd);

            //Marca licença Sistemo Operacional em uso
            cmd = "UPDATE `software_licencas` SET `qtd` = qtd - 1 WHERE (`key` = '" + KeyOS + "');";
            CG.ExecutarComandoSql(cmd);
            #endregion            

            #region SoftWare
            //Verifica se o datagridview esta vazio
            if (dgvSoftware.RowCount != 0)
            {
                //Pega os Id do Software
                cmd = "SELECT id_licenca FROM maquina_software where id_maquina = " + Id_Maquina + ";";
                CG.ExecutarComandoSql(cmd);
                CG.RetornarDadosDataTable(Dt_Software);

                //Liberar os software
                foreach (DataRow r in Dt_Software.Rows)
                {
                    Id_Software = r[0].ToString();

                    cmd = "UPDATE `software_licencas` SET `qtd` = qtd + 1 WHERE (`id` = '" + Id_Software + "');";
                    CG.ExecutarComandoSql(cmd);
                }

                //Limpa a lista de software
                cmd = "DELETE FROM `maquina_software` WHERE (`id_maquina` = '" + Id_Maquina + "');";
                CG.ExecutarComandoSql(cmd);

                Id_Software = "";

                //Salvar Software
                foreach (DataGridViewRow dgv in dgvSoftware.Rows)
                {
                    //Pega a Key e software
                    string Software = dgv.Cells[0].Value.ToString();
                    string Licenca = dgv.Cells[1].Value.ToString();

                    //Pega id Da key
                    cmd = "SELECT id FROM software_licencas where `key` = '" + Licenca + "' and software = '" + Software + "';";
                    CG.ExecutarComandoSql(cmd);
                    Id_Software = CG.RetornarValorSQL();

                    //Verifica se esta disponivel
                    cmd = "SELECT qtd FROM software_licencas where `id` = '" + Id_Software + "';";
                    CG.ExecutarComandoSql(cmd);
                    disponibilidade = int.Parse(CG.RetornarValorSQL());

                    if (disponibilidade != 0)
                    {
                        //Insere no banco de dados
                        cmd = "INSERT INTO `maquina_software` (`id_maquina`, `id_licenca`) VALUES ('" + Id_Maquina + "', '" + Id_Software + "');";
                        CG.ExecutarComandoSql(cmd);

                        //Marca Software em uso
                        cmd = "UPDATE `software_licencas` SET `qtd` = qtd - 1 WHERE (`id` = '" + Id_Software + "');";
                        CG.ExecutarComandoSql(cmd);
                    }
                    else
                    {
                        MessageBox.Show("Esta em Uso\n\n" + "Software: " + Software + "key: " + Licenca);
                    }
                }
            }
            else
            {
                //Pega os Id do Software
                cmd = "SELECT id_licenca FROM maquina_software where id_maquina = " + Id_Maquina + ";";
                CG.ExecutarComandoSql(cmd);
                CG.RetornarDadosDataTable(Dt_Software);

                //Liberar os software
                foreach (DataRow r in Dt_Software.Rows)
                {
                    Id_Software = r[0].ToString();

                    cmd = "UPDATE `software_licencas` SET `qtd` = qtd - 1 WHERE (`id` = '" + Id_Software + "');";
                    CG.ExecutarComandoSql(cmd);
                }

                //Limpa a lista de software
                cmd = "DELETE FROM `maquina_software` WHERE (`id_maquina` = '" + Id_Maquina + "');";
                CG.ExecutarComandoSql(cmd);

                Id_Software = "";
            }
            #endregion

            Close();
        }
        private void btnResetar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Resetar Padrão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }

            AtualizarForm();
            CarregarInformacoesPesquisa();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir maquina", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() != "YES")
            {
                return;
            }

            //Variavel Software
            string Id_Software = "";
            string cmd = "";
            DataTable Dt_Software = new DataTable();
            //Variaveis OS
            DataTable Dt_Os = new DataTable();
            string KeyOs = "";
            string Os = "";

            #region Software
            //Verifica se o datagridview esta vazio
            if (dgvSoftware.RowCount != 0)
            {
                //Pega os Id do Software
                cmd = "SELECT id_licenca FROM maquina_software where id_maquina = " + Id_Maquina + ";";
                CG.ExecutarComandoSql(cmd);
                CG.RetornarDadosDataTable(Dt_Software);

                //Liberar os software
                foreach (DataRow r in Dt_Software.Rows)
                {
                    Id_Software = r[0].ToString();

                    cmd = "UPDATE `software_licencas` SET `qtd` = qtd + 1 WHERE (`id` = '" + Id_Software + "');";
                    CG.ExecutarComandoSql(cmd);
                }

                //Limpa a lista de software
                cmd = "DELETE FROM `maquina_software` WHERE (`id_maquina` = '" + Id_Maquina + "');";
                CG.ExecutarComandoSql(cmd);

                Id_Software = "";
            }
            #endregion  

            #region Sistema Operacional
            cmd = "SELECT sistema_operacional, keyos FROM maquina where id = '" + Id_Maquina + "';";
            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(Dt_Os);


            foreach (DataRow r in Dt_Os.Rows)
            {
                Os = r[0].ToString();
                KeyOs = r[1].ToString();
            }

            cmd = "UPDATE `software_licencas` SET `qtd` = qtd + 1 WHERE `software` = '" + Os + "' and `key` = '" + KeyOs + "';";
            CG.ExecutarComandoSql(cmd);
            #endregion

            #region Apagar Hardware e Maquina
            cmd = "DELETE FROM `hardware` WHERE (`id` = '" + Id_hardware + "');";
            CG.ExecutarComandoSql(cmd);

            cmd = "DELETE FROM `maquina` WHERE (`id` = '" + Id_Maquina + "');";
            CG.ExecutarComandoSql(cmd);
            #endregion

            Close();
        }
    }
}

