using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_No_Lineales;
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
    public partial class Colas : Form
    {
        Cola micola;

        public Colas()
        {
            InitializeComponent();
            micola = new Cola(list); 
        }
        private void Colas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtnum.Text, out valor))
            {
                NodoBinario nuevonodo = new NodoBinario(valor);
                micola.Queue(nuevonodo); 
                micola.Mostrar(); 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                NodoBinario nodoEliminado = micola.DeQueue();
                if (nodoEliminado != null)
                {
                    MessageBox.Show("Se eliminó el valor: " + nodoEliminado.Dato);
                    micola.Mostrar();
                }
                else
                {
                    MessageBox.Show("La cola está vacía.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dato;

            if (int.TryParse(txtnum.Text, out dato))
            {
                micola.Recorrer(dato);
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }

            txtnum.Clear();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            micola.VaciarCola();
            micola.Mostrar();
            MessageBox.Show("Se vació la cola.");
        }
    }
}
