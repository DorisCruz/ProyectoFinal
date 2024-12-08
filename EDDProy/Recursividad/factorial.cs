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
    public partial class factorial : Form
    {
        private Factorialclass factorialclass;
        public factorial()
        {
            InitializeComponent();
            factorialclass = new Factorialclass();  // Inicializamos la clase Factorialclass

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número ingresado
                int numero = (int)numElementos.Value;

                int resultado = factorialclass.Calcular(numero);

                // Mostrar el resultado en el TextBox
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
