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
    public partial class frmDirecta : Form
    {
        private MezclaDirecta mezclaDirecta;
        public frmDirecta()
        {
            InitializeComponent();
            mezclaDirecta = new MezclaDirecta(); 
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidad.Value;

            mezclaDirecta.GenerarNumeros(cantidad);
            MessageBox.Show("Se genero la lista aleatoriamente");
            mezclaDirecta.MostrarNumeros(listBoxNumeros);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            mezclaDirecta.Ordenar(listBoxNumeros);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
