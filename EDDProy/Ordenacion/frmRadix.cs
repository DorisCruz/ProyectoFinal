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
    public partial class frmRadix : Form
    {
        private Radix radix; 

        public frmRadix()
        {
            InitializeComponent();
            radix = new Radix(); 
        }

        private void MostrarNumeros(int[] arreglo)
        {
            listBoxNumeros.Items.Clear();
            foreach (int numero in arreglo)
            {
                listBoxNumeros.Items.Add(numero); 
            }
        }


        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidad.Value;

            radix.GenerarNumeros(cantidad);
            MessageBox.Show("Se genero la lista aleatoriamente");
            MostrarNumeros(radix.ObtenerNumeros());
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            radix.Ordenar(MostrarNumeros);
        }
    }
}
