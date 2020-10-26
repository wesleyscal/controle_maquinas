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

        private void AtualizarForm()
        {
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
                string cmd = "SELECT * FROM software_licencas where software = '" + Software + "';";
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
                string cmd = "SELECT * FROM software_licencas where software = '" + Software + "';";
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
            string software = cbbSoftware.Text;
            string key = cbbKey.Text;
            if (cbbSoftware.Text != "Selecionar Software")
            {
                if (cbbKey.Text != "Selecionar licença")
                {
                    dgvSoftware.Rows.Add(software, key);
                }
                else
                {
                    MessageBox.Show("Selecione a key");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione um Software");
                return;
            }

            cbbSoftware.SelectedIndex = 0;
            cbbKey.SelectedIndex = 0;

        }
        private void btnLimparSoftware_Click(object sender, EventArgs e)
        {
            dgvSoftware.Rows.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtDominio.Text.Trim() == "")
            {
                MessageBox.Show("Informe o domínio!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtMaquina.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Nome da maquina!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Usuário real!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtProcessador.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Processador\nCaso não tenha Informe \"NA\" !", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtMemoria.Text.Trim() == "")
            {
                MessageBox.Show("Informe a Memoria\nCaso não tenha Informe \"NA\" !", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtArmazenamento.Text.Trim() == "")
            {
                MessageBox.Show("Informe o Armazenamento\nCaso não tenha Informe \"NA\" !", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(txtGpu.Text.Trim() == "")
            {
                MessageBox.Show("Informe a GPU\nCaso não tenha Informe \"NA\" !", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(cbbOS.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione o Sistema Operacional!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(cbbKeyOS.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione a Key do Sistema Operacional!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           





        }
    }
}
