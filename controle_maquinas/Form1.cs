using Fd_DBC;
using ordem_de_servico;
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

        public Form1()
        {
            InitializeComponent();
        }

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

        }

        private void btnNovoSoftware_Click(object sender, EventArgs e)
        {
            NovoSoftware form = new NovoSoftware();
            form.ShowDialog();
        }

        private void btnNovaMaquina_Click(object sender, EventArgs e)
        {
            NovaMaquina Form = new NovaMaquina();
            Form.ShowDialog();
        }
    }
}
