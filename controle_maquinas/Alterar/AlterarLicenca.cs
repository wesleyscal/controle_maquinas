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
    public partial class AlterarLicenca : Form
    {
        DBC CG = new DBC();
        string Id_Licenca = SoftwareLicenca.AlterarLicenca;


        public AlterarLicenca()
        {
            InitializeComponent();
        }

        //Metodos
        private void CarregarDados()
        {
            DataTable dt = new DataTable();
            string Fpp = "";
            string Disponivel = "";

            string cmd = "SELECT * FROM software_licencas where id = '" + Id_Licenca + "';";
            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(dt);

            foreach (DataRow r in dt.Rows)
            {
                txtSoftware.Text = r[1].ToString();
                txtKey.Text = r[2].ToString();
                txtNfe.Text = r[3].ToString();
                Fpp = r[4].ToString();
                Disponivel = r[5].ToString();
                txtObservacao.Text = r[6].ToString();
            }

            if (Fpp == "s")
            {
                rdbUnica.Checked = true;
                rdbMultiplas.Checked = false;
            }
            if (Fpp == "n")
            {
                rdbUnica.Checked = false;
                rdbMultiplas.Checked = true;
            }

            if (Disponivel == "s")
            {
                ckbDisponivel.Checked = true;
            }
            if (Disponivel == "n")
            {
                ckbDisponivel.Checked = false;
            }

        }

        //Form
        private void AlterarLicenca_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        //Botão
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string cmd = "";
            string Key = txtKey.Text;
            string Nfe = txtNfe.Text;
            string Fpp = "";
            string Disponivel = "";
            string Observacao = txtObservacao.Text;

            if(rdbUnica.Checked == true)
            {
                Fpp = "s";
            }
            if(rdbMultiplas.Checked == true)
            {
                Fpp = "n";
            }

            if(ckbDisponivel.Checked == true)
            {
                Disponivel = "s";
            }
            else
            {
                Disponivel = "n";
            }

            cmd = "UPDATE `software_licencas` " +
                  "SET `key` = '" + Key + "', " +
                      "`nfe` = '" + Nfe + "', " +
                      "`fpp` = '" + Fpp + "', " +
                      "`disponivel` = '" + Disponivel + "', " +
                      "`observacao` = '" + Observacao + "' " +
                  "WHERE (`id` = '" + Id_Licenca + "');";
            CG.ExecutarComandoSql(cmd);

            Close();
        }
        private void btnResetar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
