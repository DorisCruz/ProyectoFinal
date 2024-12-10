using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class factorial : Form
    {
        private Factorialclass factorialclass;
        public factorial()
        {
            InitializeComponent();
            factorialclass = new Factorialclass();  

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = (int)numElementos.Value;
                Stopwatch cronometro = Stopwatch.StartNew();
                int resultado = factorialclass.Calcular(numero);
                cronometro.Stop();
                txtResultado.Text = resultado.ToString();

                tiempo.Text = $"{cronometro.Elapsed.TotalMilliseconds} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
