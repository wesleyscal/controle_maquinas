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
    public partial class Form1 : Form
    {
        DBC CG = new DBC();
        public static DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        //Metodos
        private void ConfigCBB()
        {
            cbbSoftware.Items.Clear();

            cbbSoftware.Items.Add("Todos os Software");
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
        private void CarregarDGV()
        {
            string cmd = "select id, nome_maquina 'Nome Maquina', nome_dominio 'Nome Dominio', nome_usuario 'Nome Usuario', sistema_operacional 'Sistema Operacional' from maquina";
            CG.ExecutarComandoSql(cmd);
            CG.ExibirDGV(dgvMaquinas);
            CG.FormatarDGV(dgvMaquinas);
            dgvMaquinas.Columns[0].Visible = false;
        }

        //Form
        private void Form1_Load(object sender, EventArgs e)
        {
            //Configurar Banco
            try
            {
                CG.ConectarBancoDeDados();
            }
            catch
            {
                ConfigurarBanco CB = new ConfigurarBanco();
                CB.ShowDialog();
            }

            ConfigCBB();
            CarregarDGV();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ConfigCBB();
                CarregarDGV();
            }

            if (e.KeyCode == Keys.F4)
            {
                ConfigurarBanco CB = new ConfigurarBanco();
                CB.ShowDialog();
            }

        }

        //Botão
        private void btnNovoSoftware_Click(object sender, EventArgs e)
        {
            NovaLicenca form = new NovaLicenca();
            form.ShowDialog();
        }
        private void btnNovaMaquina_Click(object sender, EventArgs e)
        {
            NovaMaquina Form = new NovaMaquina();
            Form.ShowDialog();

            ConfigCBB();
            CarregarDGV();
        }
        private void btnSoftwareLicenca_Click(object sender, EventArgs e)
        {
            SoftwareLicenca form = new SoftwareLicenca();
            form.ShowDialog();

            ConfigCBB();
            CarregarDGV();
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
                string cmd = "SELECT * FROM software_licencas where software = '" + Software + "' ;";
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

        //DataGridView
        private void dgvMaquinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string codigo = dgvMaquinas.CurrentRow.Cells[0].Value.ToString();

                string cmd = "select * " +
                             "from maquina " +
                             "where id = '" + codigo + "'";
                CG.ExecutarComandoSql(cmd);
                CG.RetornarDadosDataTable(dt);

                Maquina Form = new Maquina();
                Form.ShowDialog();

                ConfigCBB();
                CarregarDGV();
            }
        }


    }
}
