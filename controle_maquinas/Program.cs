using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_maquinas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());           
        }

        public static string InputBoxRetorno(string Cabecalho, string Texto, string Valor)
        {
            InputBox frm = new InputBox(Cabecalho, Texto, Valor);
            frm.ShowDialog();
            string resultado = frm.InputResult();
            return resultado;
        }
    }
}
