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
    public partial class listadoble : Form
    {
        private ListaDoble objLista; // Instancia de la clase ListaDoble
    

        public listadoble()
        {
            InitializeComponent();
            objLista = new ListaDoble(list); // Inicializar la lista doble al cargar el formulario
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textnum.Text, out int valor))
            {
                objLista.InsertarNodo(valor);
                MessageBox.Show("Nodo agregado: " + valor);
                textnum.Clear();
                textnum.Focus();
            }
            else
            {
                MessageBox.Show("Introduce un número válido.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textnum.Text, out int dato))
            {
                int posicion = objLista.Buscar(dato);
                if (posicion != -1)
                {
                    MessageBox.Show("El dato " + dato + " se encuentra en la posición " + posicion);
                }
                else
                {
                    MessageBox.Show("El dato no se encuentra en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textnum.Text, out int posicion))
            {
                objLista.EliminarPorPosicion(posicion, list);
                objLista.VerLista(list, true);
            }
            else
            {
                MessageBox.Show("Introduce una posición válida.");
            }
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            objLista.VerLista(list, true);
        }

        private void btnDI_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            objLista.VerLista(list, false);
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            objLista.VaciarLista(list);
        }

        private void listadoble_Load(object sender, EventArgs e)
        {

        }
    }
}
