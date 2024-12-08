using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class fibonacci : Form
    {
        private Fibonacci fiibonacci;

        public fibonacci()
        {
            InitializeComponent();
            fiibonacci = new Fibonacci();
        }

        private void fibonacci_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int nuElementos = (int)numElementos.Value;

                int[] resultado = fiibonacci.Calcular(nuElementos);
                txtResultado.ReadOnly = true;
                txtResultado.Text = string.Join(", ", resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
