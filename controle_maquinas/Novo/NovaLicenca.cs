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
    public partial class NovaLicenca : Form
    {
        DBC CG = new DBC();
        string Software;

        public NovaLicenca(string software)
        {
            InitializeComponent();
            Software = software;
        }

        //Form
        private void NovaLicenca_Load(object sender, EventArgs e)
        {
            txtSoftware.Text = Software;
            rdbUnica.Checked = true;
            txtQuantidade.ReadOnly = true;
            txtQuantidade.Text = "1";

        }
        private void NovaLicenca_KeyDown(object sender, KeyEventArgs e)
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

        //Botao
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            txtNfe.Clear();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Trim() == "")
            {
                MessageBox.Show("Campo Key vazio");
                return;
            }
            if (txtNfe.Text.Trim() == "")
            {
                MessageBox.Show("Campo NF-e vazio");
                return;
            }
            if (txtQuantidade.Text.Trim() == "")
            {
                MessageBox.Show("Campo Quantidade vazio");
                return;
            }
            string cmd = "";
            string Software = txtSoftware.Text;
            string Key = txtKey.Text;
            string nfe = txtNfe.Text;
            string observacao = txtObservacao.Text;
            int qtd = int.Parse(txtQuantidade.Text);
            int qtdmax = int.Parse(txtQuantidade.Text);
            DataTable ValidarKey = new DataTable();

            //Validar Key
            cmd = "SELECT `key` FROM controle_maquina.software_licencas;";
            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(ValidarKey);

            foreach(DataRow r in ValidarKey.Rows)
            {
                if (Key == r[0].ToString())
                {
                    MessageBox.Show("Key existente");
                    return;
                }
            }

            //Adiciona a licenca
            cmd = "INSERT INTO `software_licencas` " +
               "(`software`, `key`, `qtd`, `qtdmax`, `nfe`, `observacao`) " +
               "VALUES ('" + Software + "', '" + Key + "', '" + qtd + "', '" + qtdmax + "', '" + nfe + "', '" + observacao + "');";
            CG.ExecutarComandoSql(cmd);

            txtKey.Clear();
            txtNfe.Clear();
            txtObservacao.Clear();
            txtQuantidade.Text = "1";
            rdbUnica.Checked = true;

        }

        //RadioButton
        private void rdbMultiplas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMultiplas.Checked == true)
            {
                txtQuantidade.ReadOnly = false;
            }
        }
        private void rdbUnica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUnica.Checked == true)
            {
                txtQuantidade.ReadOnly = true;
                txtQuantidade.Text = "1";
            }
        }

        //textBox
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            bool ivia;

            ivia = CG.ValidarNumero(txtQuantidade.Text);

            if (ivia == false)
            {
                txtQuantidade.Clear();
            }
        }


    }
}