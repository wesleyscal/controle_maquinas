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
            int Qtd = 0;
            int QtdMax = 0;
            int QtdUso = 0;

            string cmd = "SELECT * FROM software_licencas where id = '" + Id_Licenca + "';";
            CG.ExecutarComandoSql(cmd);
            CG.RetornarDadosDataTable(dt);

            foreach (DataRow r in dt.Rows)
            {
                txtSoftware.Text = r[1].ToString();
                txtKey.Text = r[2].ToString();
                Qtd = int.Parse(r[3].ToString());
                QtdMax =  int.Parse(r[4].ToString());
                txtNfe.Text = r[5].ToString();                
                txtObservacao.Text = r[6].ToString();
            }
            QtdUso = QtdMax - Qtd;

            txtQtdTotal.Text = QtdMax.ToString();
            txtQtdLivre.Text = Qtd.ToString();
            txtQtdUso.Text = QtdUso.ToString();         

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
            string Observacao = txtObservacao.Text;

            

            cmd = "UPDATE `software_licencas` " +
                  "SET `key` = '" + Key + "', " +
                      "`nfe` = '" + Nfe + "', " +
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
