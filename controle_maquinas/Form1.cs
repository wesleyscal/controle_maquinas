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

        }

        private void btnNovoSoftware_Click(object sender, EventArgs e)
        {
            NovoSoftware form = new NovoSoftware();
            form.ShowDialog();
        }
    }
}
