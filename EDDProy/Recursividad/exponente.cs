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
    public partial class exponente : Form
    {
        private Exponentes exponentes;
        public exponente()
        {
            InitializeComponent();
            exponentes = new Exponentes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double baseNumero = double.Parse(txtBase.Text);
                int exponente = int.Parse(txtExponente.Text);

                double resultado = exponentes.Calcular(baseNumero, exponente);

                lblResultado.Text = $" {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
