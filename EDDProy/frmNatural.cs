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
    public partial class frmNatural : Form
    {
        private MezclaNatural mezclaNatural; 

        public frmNatural()
        {
            InitializeComponent();
            mezclaNatural = new MezclaNatural();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numCantidad.Value;

            mezclaNatural.GenerarNumeros(cantidad);
            MessageBox.Show("Se genero la lista aleatoriamente");
            mezclaNatural.MostrarNumeros(listBoxNumeros);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            mezclaNatural.Ordenar(listBoxNumeros);
        }
    }
}
