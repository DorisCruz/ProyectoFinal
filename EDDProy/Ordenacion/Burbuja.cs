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
    public partial class Burbuja : Form
    {
        private burbujacl numeros; 

        public Burbuja()
        {
            InitializeComponent();
            numeros = new burbujacl(); 
        }

        private void MostrarNumeros()
        {
            listBoxNumeros.Items.Clear(); 
            int[] numerosActuales = numeros.ObtenerNumeros(); 

            foreach (int numero in numerosActuales)
            {
                listBoxNumeros.Items.Add(numero); 
            }
        }


        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidad.Value;

            numeros.GenerarNumeros(cantidad);
            MostrarNumeros();
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            numeros.Ordenar();
            MostrarNumeros();
        }
    }
}
