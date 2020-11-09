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
    public partial class InputBox : Form
    {
        string valor = "";

        public InputBox(string Cabecalho, string Texto, string Valor)
        {
            InitializeComponent();
            this.Text = Cabecalho;
            lblTexto.Text = Texto;
            txtValor.Text = Valor;
            valor = Valor;
        }

        public string InputResult()
        {
            return valor;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            valor = txtValor.Text;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
