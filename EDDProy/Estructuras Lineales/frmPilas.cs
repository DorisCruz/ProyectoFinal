using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;


namespace EDDemo
{
    public partial class frmPilas : Form
    {
        private Pilas mipila; // Instancia de la clase Pilas.

        public frmPilas()
        {
            InitializeComponent();
            mipila = new Pilas(); // Inicialización de la pila.
        }

        // Método para agregar un elemento a la pila.
        private void btnPush_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtnum.Text, out valor)) // Verifica si el input es un número válido.
            {
                mipila.Push(valor); // Llama al método Push para agregar a la pila.
                MessageBox.Show("Se agregó el valor " + valor + " a la pila.");
                ActualizarListBox(); // Actualiza la lista mostrada en pantalla.
                txtnum.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
            txtnum.Focus(); // Enfoca nuevamente el TextBox.
        }

        

        // Método para actualizar el contenido del ListBox con los elementos de la pila.
        private void ActualizarListBox()
        {
            Listashow.Items.Clear(); // Limpia el ListBox.
            Nodo actual = mipila.ObtenerTope(); // Obtiene el nodo tope de la pila.
            while (actual != null)
            {
                Listashow.Items.Add(actual.Dato); // Agrega el dato al ListBox.
                actual = actual.Sig; // Pasa al siguiente nodo.
            }
        }

        // Método para manejar la carga del formulario.
        private void frmPilas_Load(object sender, EventArgs e)
        {
            // Inicializaciones adicionales si son necesarias.
        }

        private void btnPop_Click_1(object sender, EventArgs e)
        {
            int valorEliminado = mipila.Pop(); // Llama al método Pop.
            if (valorEliminado != -1)
            {
                MessageBox.Show("Se eliminó el valor " + valorEliminado + " de la pila.");
                ActualizarListBox(); // Actualiza la lista mostrada en pantalla.
            }
            else
            {
                MessageBox.Show("La pila está vacía. No se puede eliminar más elementos.");
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            int dato;
            if (int.TryParse(txtnum.Text, out dato)) // Verifica si el input es un número válido.
            {
                int posicion = mipila.buscar(dato); // Llama al método buscar.
                if (posicion != -1)
                {
                    MessageBox.Show("El dato " + dato + " se encuentra en la posición " + posicion + " (desde el tope).");
                }
                else
                {
                    MessageBox.Show("El dato no se encuentra en la pila.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
            txtnum.Clear();
            txtnum.Focus();
        }

        private void btnVaciar_Click_1(object sender, EventArgs e)
        {
            mipila.Vaciar(); // Llama al método Vaciar de la clase Pilas.
            MessageBox.Show("La pila se vació correctamente.");
            ActualizarListBox(); // Limpia la lista mostrada en pantalla.
        }

        private void frmPilas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
