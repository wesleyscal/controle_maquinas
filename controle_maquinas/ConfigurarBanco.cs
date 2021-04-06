using Fd_DBC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        //Metodo
        private void Backup()
        {
            int i = 0;
            // Variáveis de execução de comando
            ProcessStartInfo inf = new ProcessStartInfo("cmd.exe");
            Process proc = new Process();

            // Verifica se tem o MySQL instalado para realizar o Backup
            if (!File.Exists(@"C:\Program Files\MySQL\MySQL Server 5.7\bin\MysqlDump.exe"))
            {
                // Exibe a mensagem de erro
                MessageBox.Show("Falha ao realizar o backup! (Verifique se você possui o MySQL Server 5.7 instalado).", "Erro de Backup !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Encerra a rotina
                return;
            }

            // Oculta a janela do prompt
            inf.CreateNoWindow = true;
            inf.UseShellExecute = false;
            // Indica o caminho de execução do processo
            proc.StartInfo = inf;


            DataTable dt = new DataTable();
            CG.RetornarConfigBanco(dt);

            string Servidor = dt.Rows[0][0].ToString();
            string Port = dt.Rows[1][0].ToString();
            string User = dt.Rows[2][0].ToString();
            string Banco = dt.Rows[3][0].ToString();
            string Senha = "";

            while (i == 0)
            {


                try
                {
                    Senha = Program.InputBoxRetorno("Segurança", "Ensira a senha do Banco de dados", "senha");

                    CG.ConfigConexao(Servidor, Port, User, Banco, Senha);
                    CG.ConectarBancoDeDados();
                    i++;
                }
                catch
                {
                    DialogResult Res = MessageBox.Show("Senha Incoreta", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                    if (Res == DialogResult.Retry)
                    {
                        Senha = dt.Rows[4][0].ToString();
                        CG.ConfigConexao(Servidor, Port, User, Banco, Senha);
                    }

                    if (Res == DialogResult.Cancel)
                    {
                        return;
                    }

                }
            }

            //Seleciona o local do backup
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string bkpPath = FBD.SelectedPath + @"\";
                // Argumento da execução do processo
                proc.StartInfo.Arguments = @"/c c: & cd\ & ""C:\Program Files\MySQL\MySQL Server 5.7\bin\"""
                                         + "MysqlDump.exe -h" + Servidor + " -u " + User + " -p" + Senha + " -e -c -l " + Banco + ">> "
                                         + "\"" + bkpPath + "\"" + Banco + "_\"(%date:~0,2%-%date:~3,2%-%date:~6,4%)_(%time:~0,2%-%time:~3,2%)\".sql";

                // Inicia o processo
                proc.Start();
                // Espera o processo encerrar
                proc.WaitForExit();
            }
            else
            {
                MessageBox.Show("A operação foi cancelada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Backup concluído. Deseja abrir o diretório ?", "Sucesso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // Abre a pasta de backup
                Process.Start(FBD.SelectedPath);
            }

        }
        private void RestaurarBackup()
        {
            int i = 0;
            string ResBkpPath = "";
            // Verifica se tem o MySQL instalado para realizar o Backup
            if (!File.Exists(@"C:\Program Files\MySQL\MySQL Server 5.7\bin\Mysql.exe"))
            {
                // Exibe a mensagem de erro
                MessageBox.Show("Falha ao realizar a restauração do backup! (Verifique se você possui o MySQL Server 5.7 instalado).", "Erro de Backup !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Encerra a rotina
                return;
            }


            // Variáveis de execução de comando
            ProcessStartInfo inf = new ProcessStartInfo("cmd.exe");
            Process proc = new Process();

            if (MessageBox.Show
                 ( "O procedimento realizará a restauração do Banco de dados.\n\n TODOS OS DADOS ANTERIORES SERÃO PERDIDOS.\n\n Deseja continuar ?",
                  "Atenção !",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Exclamation)
                 == DialogResult.Yes)
            {

                OFD.Title = "Restaurar Backup Controle de Portaria";
                OFD.FileName = "";

                // Exibe a caixa de diálogo
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    // Exibe a pasta e arquivo selecionada na label lbllocal
                    ResBkpPath = "\"" + OFD.FileName + "\"";
                }
                else
                {
                    MessageBox.Show("A operação foi cancelada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Oculta a janela do prompt
                inf.CreateNoWindow = true;
                inf.UseShellExecute = false;
                // Indica o caminho de execução do processo
                proc.StartInfo = inf;

                DataTable dt = new DataTable();
                CG.RetornarConfigBanco(dt);

                string Servidor = dt.Rows[0][0].ToString();
                string Port = dt.Rows[1][0].ToString();
                string User = dt.Rows[2][0].ToString();
                string Banco = dt.Rows[3][0].ToString();
                string Senha = "";

                while (i == 0)
                {
                    try
                    {
                        Senha = Program.InputBoxRetorno("Segurança", "Ensira a senha do Banco de dados", "senha");

                        CG.ConfigConexao(Servidor, Port, User, Banco, Senha);
                        CG.ConectarBancoDeDados();
                        i++;
                    }
                    catch
                    {
                        DialogResult Res = MessageBox.Show("Senha Incoreta", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                        if (Res == DialogResult.Retry)
                        {
                            Senha = dt.Rows[4][0].ToString();
                            CG.ConfigConexao(Servidor, Port, User, Banco, Senha);
                        }

                        if (Res == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                }

                // Argumento da execução do processo
                proc.StartInfo.Arguments = @"/c c: & cd\ & cd ""Program Files\MySQL\MySQL Server 5.7\bin\"""
                                        + "& mysql.exe -h" + Servidor + " -u " + User + " -p" + Senha + " " + Banco + " < " + ResBkpPath + "";

                // Inicia o processo
                proc.Start();
                // Espera o processo encerrar
                proc.WaitForExit();

            }
            else
            {
                // Encerra a rotina
                return;
            }

            MessageBox.Show("Restauração de backup concluída!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            if (e.KeyCode == Keys.F2)
            {
                Backup();
            }

            if (e.KeyCode == Keys.F3)
            {
                RestaurarBackup();
            }

        }
    }
}
