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
    public partial class frmHash : Form
    {
        private Hash hash;
        private int[] numerosGenerados;
        public frmHash()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cantidad = (int)numCantidad.Value;
            numerosGenerados = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                numerosGenerados[i] = random.Next(1, 101);
            }

            hash = new Hash(cantidad * 2);
            hash.Insertar(numerosGenerados);

            lblLista.Text = "Números generados: " + string.Join(", ", numerosGenerados);
            lblTablaHash.Text = hash.MostrarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (hash == null || numerosGenerados == null)
            {
                MessageBox.Show("Primero debes generar los números y crear la tabla hash.");
                return;
            }

            if (int.TryParse(txtBuscar.Text, out int numeroABuscar))
            {
                int? posicion = hash.Buscar(numeroABuscar);

                if (posicion != null)
                {
                    MessageBox.Show($"El número {numeroABuscar} se encuentra en la posición {posicion} de la tabla hash.");
                }
                else
                {
                    MessageBox.Show($"El número {numeroABuscar} no se encuentra en la tabla hash.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido para buscar.");
            }
        }
    }
}
