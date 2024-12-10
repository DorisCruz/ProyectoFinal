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
    public partial class busquedabinaria : Form
    {
        private List<int> listaNumeros;
        private Binaria busquedaBinaria;
        public busquedabinaria()
        {
            InitializeComponent();
            busquedaBinaria = new Binaria();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listaNumeros = new List<int>();  

            int cantidad = (int)numCantidad.Value;

            for (int i = 0; i < cantidad; i++)
            {
                listaNumeros.Add(random.Next(1, 101));
            }

            listaNumeros.Sort();

            lblLista.Text = string.Join(", ", listaNumeros);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaNumeros == null || listaNumeros.Count == 0)
                {
                    MessageBox.Show("Primero debes generar una lista.");
                    return;
                }

                if (int.TryParse(txtBuscar.Text, out int numeroABuscar))
                {
                    int posicion = busquedaBinaria.Buscar(listaNumeros.ToArray(), numeroABuscar);

                    if (posicion != -1)
                    {
                        MessageBox.Show("El número " + numeroABuscar + " esta en la posicion " + posicion);
                    }
                    else
                    {
                        MessageBox.Show("El número " + numeroABuscar + " no esta en la lista");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido en el campo de búsqueda.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
