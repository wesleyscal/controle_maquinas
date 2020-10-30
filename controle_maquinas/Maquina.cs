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
        string KeyOS = "";
        string Id_Maquina = "";


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
            //Formata DGV
            CG.FormatarDGV(dgvSoftware); 

            //Remover linha em branco DataGridView
            dgvSoftware.AllowUserToAddRows = false;
            dgvSoftware.AllowUserToDeleteRows = false;

            AtualizarForm();
            CarregarInformacoesPesquisa();
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
            string Id_Licenca = "";
            string cmd = "";

            //Limpar Software
            foreach (DataGridViewRow dgv in dgvSoftware.Rows)
            {
                //Pega a Key
                string key = dgv.Cells[1].Value.ToString();

                //Pega id Da key
                cmd = "SELECT id FROM software_licencas where `key` = '" + key + "';";
                CG.ExecutarComandoSql(cmd);
                Id_Licenca = CG.RetornarValorSQL();

                //Marca Software como Disponivel
                cmd = "UPDATE `software_licencas` SET `disponivel` = 's' WHERE (`id` = '" + Id_Licenca + "' and fpp = 's');";
                CG.ExecutarComandoSql(cmd);
            }

            dgvSoftware.Rows.Clear();
            cbbSoftware.SelectedIndex = 0;
            cbbKey.SelectedIndex = 0;

            cmd = "DELETE FROM `maquina_software` WHERE (`id_maquina` = '" + Id_Maquina + "');";
            CG.ExecutarComandoSql(cmd);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {            

        }

        /*----------------------------------------------------------------------------------------------------------------------------------------------
         * ----------------------------------------------------------------------------------------------------------------------------------------------
         * --------------------------------------------VVVVVVVVV-Nova Parte-VVVVVVVVV---------------------------------------------------------------------
         * ----------------------------------------------------------------------------------------------------------------------------------------------
         * ----------------------------------------------------------------------------------------------------------------------------------------------
         * ----------------------------------------------------------------------------------------------------------------------------------------------
         */

        private void CarregarInformacoesPesquisa()
        {
            //Declara os DataTable
            DataTable Dt_Maquina = new DataTable();
            DataTable Dt_Software = new DataTable();

            //Variaveis
            string cmd = "";
            string PcNote = "";            
            string Id_hardware = "";
            string Id_Software = "";
            string Software = "";
            string KeySoftware = "";

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
                cbbOS.SelectedItem = r[7].ToString();
                cbbKeyOS.SelectedItem = r[8].ToString();
                KeyOS = r[8].ToString();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgvSoftware.RowCount == 0)
            {
                MessageBox.Show("Não a Licenca");
                return;
            }

            dgvSoftware.Rows.RemoveAt(dgvSoftware.CurrentRow.Index);
        }
    }
}

