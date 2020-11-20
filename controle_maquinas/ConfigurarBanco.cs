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
    public partial class ConfigurarBanco : Form
    {
        DBC CG = new DBC();


        public ConfigurarBanco()
        {
            InitializeComponent();
        }

        //Botão
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Servidor = txtServidor.Text;
            string Port = txtPorta.Text;
            string User = txtUser.Text;
            string Banco = txtBanco.Text;
            string Senha = txtSenha.Text;
            try
            {
                CG.ConfigConexao(Servidor, Port, User, Banco, Senha);
                CG.ConectarBancoDeDados();
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi possivel conectar ao banco");
            }

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBanco.Clear();
            txtPorta.Clear();
            txtSenha.Clear();
            txtServidor.Clear();
            txtUser.Clear();
        }

        //Form
        private void ConfigurarBanco_Load(object sender, EventArgs e)
        {
            btnSalvar.Select();

            DataTable dt = new DataTable();
            CG.RetornarConfigBanco(dt);

            txtServidor.Text = dt.Rows[0][0].ToString();
            txtPorta.Text = dt.Rows[1][0].ToString();
            txtUser.Text = dt.Rows[2][0].ToString();
            txtBanco.Text = dt.Rows[3][0].ToString();
            txtSenha.Text = dt.Rows[4][0].ToString();
        }
        private void ConfigurarBanco_KeyDown(object sender, KeyEventArgs e)
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
    }
}
