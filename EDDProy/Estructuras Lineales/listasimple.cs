using EDDemo.Estructuras_Lineales;
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
    public partial class listasimple : Form
    {
        private Listas miLista;

        public listasimple()
        {
            InitializeComponent();
            miLista = new Listas(listashow); // Instancia de la clase Listas.
        }



        private void listasimple_Load(object sender, EventArgs e)
        {
            // Método del evento Load, si se requiere inicialización.
        }

        private void listasimple_Load_1(object sender, EventArgs e)
        {

        }



     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtpos.Text, out int posicion))
            {
                string dato = textnum.Text;
                miLista.Insertar(posicion, dato);
                MessageBox.Show($"Se agregó el valor {dato}");
                miLista.ActualizarLista();
                textnum.Clear();
                txtpos.Clear();
            }
            else
            {
                MessageBox.Show("Introduce una posición válida.");
            }
        }

        private void btnElim_Click_1(object sender, EventArgs e)
        {
            string datoAEliminar = textnum.Text;

            if (!string.IsNullOrEmpty(datoAEliminar))
            {
                miLista.Eliminar(datoAEliminar);
                MessageBox.Show($"Se eliminó {datoAEliminar}");
                miLista.ActualizarLista();
                textnum.Clear();
            }
            else
            {
                MessageBox.Show("Introduce un dato válido para eliminar.");
            }
        }

        private void btnBus_Click_1(object sender, EventArgs e)
        {
            string dato = textnum.Text;

            if (!string.IsNullOrEmpty(dato))
            {
                int posicion = miLista.Buscar(dato);
                if (posicion != -1)
                {
                    MessageBox.Show($"El dato {dato} se encuentra en la posición {posicion}");
                }
                else
                {
                    MessageBox.Show("El dato no se encuentra en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Introduce un dato válido.");
            }

            textnum.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
