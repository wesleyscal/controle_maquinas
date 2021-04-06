using System;
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

        //Metodos
        public string InputResult()
        {
            return valor;
        }

        //Botão
        private void btnOk_Click(object sender, EventArgs e)
        {
            valor = txtValor.Text;
            Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //TextBox
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                valor = txtValor.Text;
                Close();
            }
        }

        //Form
        private void InputBox_Load(object sender, EventArgs e)
        {
            if(txtValor.Text == "senha")
            {
                txtValor.Clear();
                txtValor.PasswordChar = Convert.ToChar("*");
            }
            txtValor.Focus();
        }
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
