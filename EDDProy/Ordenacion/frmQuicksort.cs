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
    public partial class frmQuicksort : Form
    {
        private Quicksort quicksort;

        public frmQuicksort()
        {
            InitializeComponent();
            quicksort = new Quicksort(); 
        }

        private void MostrarNumeros()
        {
            listBoxNumeros.Items.Clear(); 
            int[] numerosActuales = quicksort.ObtenerNumeros(); 

            foreach (int numero in numerosActuales)
            {
                listBoxNumeros.Items.Add(numero);
            }
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidad.Value;

            quicksort.GenerarNumeros(cantidad);
            MessageBox.Show("Se genero la lista aleatoriamente");
            MostrarNumeros();
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            quicksort.Ordenar(); 
            MostrarNumeros();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
