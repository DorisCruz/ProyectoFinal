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
    public partial class torresdehanoi : Form
    {
        private Hanoi hanoi;
        public torresdehanoi()
        {
            InitializeComponent();
            hanoi = new Hanoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cantidad de discos del NumericUpDown
                int discos = (int)numDiscos.Value;

                if (discos <= 0)
                {
                    MessageBox.Show("Por favor, selecciona un número válido de discos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Limpiar movimientos previos
                hanoi.Movimientos.Clear();
                lstMovimientos.Items.Clear();

                // Resolver Torres de Hanoi
                hanoi.Resolver(discos, "Origen", "Destino", "Auxiliar");

                // Mostrar los movimientos en el ListBox
                foreach (string movimiento in hanoi.Movimientos)
                {
                    lstMovimientos.Items.Add(movimiento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
