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
    public partial class frmShellsort : Form
    {

            private Shellsort shellSort;

            public frmShellsort()
            {
                InitializeComponent();
            shellSort = new Shellsort();
            }

            // Método para mostrar los números en el ListBox.
            private void MostrarNumeros(int[] arreglo)
            {
                listBoxNumeros.Items.Clear(); // Limpia los elementos existentes.
                foreach (int numero in arreglo)
                {
                    listBoxNumeros.Items.Add(numero); // Agrega cada número al ListBox.
                }
            }


        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            // Obtener la cantidad de números seleccionada por el usuario
            int cantidad = (int)numCantidad.Value;

            // Generar los números con la cantidad seleccionada
            shellSort.GenerarNumeros(cantidad);
            MessageBox.Show("Se genero la lista aleatoriamente");
            MostrarNumeros(shellSort.ObtenerNumeros());
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            shellSort.Ordenar(MostrarNumeros);
        }
    }
}
