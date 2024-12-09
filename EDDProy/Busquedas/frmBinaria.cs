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
    public partial class frmBinaria : Form
    {
        private BusquedaBinaria busquedaBinaria;

        public frmBinaria()
        {
            InitializeComponent();
            busquedaBinaria = new BusquedaBinaria();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidad.Value;
            busquedaBinaria.GenerarNumeros(cantidad);
            busquedaBinaria.MostrarNumeros(listBoxNumeros);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxObjetivo.Text, out int objetivo))
            {
                int resultado = busquedaBinaria.Buscar(objetivo);

                if (resultado != -1)
                {
                    MessageBox.Show($"Número encontrado en el índice {resultado}.", "Resultado");
                }
                else
                {
                    MessageBox.Show("Número no encontrado.", "Resultado");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para buscar.");
            }
        }
    }
}
