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
    
    public partial class listacircular : Form
    {
        private ListaCircular miLista; 

        public listacircular()
        {
            InitializeComponent();
            miLista = new ListaCircular(); 
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtnum.Text, out int valor))
            {
                miLista.Insertar(valor);
                miLista.VerLista(list, false);
                txtnum.Clear();
                txtnum.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtnum.Text, out int dato))
            {
                int posicion = miLista.Buscar(dato);
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            if (int.TryParse(txtnum.Text, out int posicion))
            {
                miLista.EliminarPorPosicion(posicion, list);
                miLista.VerLista(list, false);
            }
            else
            {
                MessageBox.Show("Ingresa una posición válida.");
            }
        }

        private void btnVaciar_Click_1(object sender, EventArgs e)
        {
            miLista.VaciarLista(list);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
