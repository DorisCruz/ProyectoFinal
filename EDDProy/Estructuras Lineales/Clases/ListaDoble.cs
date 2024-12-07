using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public class ListaDoble
    {
        private Nodo primero;
        private Nodo ultimo;
        private ListBox list;

        public ListaDoble(ListBox list)
        {
            primero = null;
            ultimo = null;
            this.list = list;
        }

        // Insertar un nodo al final
        public void InsertarNodo(int valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (primero == null)
            {
                primero = nuevo;
                primero.Sig = null;
                primero.Ant = null;
                ultimo = primero;
            }
            else
            {
                ultimo.Sig = nuevo;
                nuevo.Sig = null;
                nuevo.Ant = ultimo;
                ultimo = nuevo;
            }
        }

        // Buscar un valor en la lista
        public int Buscar(int dato)
        {
            if (primero == null)
                return -1;

            Nodo actual = primero;
            while (actual != null)
            {
                if (actual.Dato == dato)
                    return dato;

                actual = actual.Sig;
            }

            return -1;
        }

        // Vaciar la lista
        public void VaciarLista(ListBox list)
        {
            primero = null;
            ultimo = null;
            list.Items.Clear();
        }

        // Ver lista (de izquierda a derecha o viceversa)
        public void VerLista(ListBox list, bool derechaIzquierda)
        {
            list.Items.Clear();

            Nodo actual;
            if (derechaIzquierda)
            {
                actual = ultimo;
                while (actual != null)
                {
                    list.Items.Add(actual.Dato + " ");
                    actual = actual.Ant;
                }
            }
            else
            {
                actual = primero;
                while (actual != null)
                {
                    list.Items.Add(actual.Dato + " ");
                    actual = actual.Sig;
                }
            }
        }

        // Eliminar nodo por posición
        public void EliminarPorPosicion(int posicion, ListBox list)
        {
            if (primero == null)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            Nodo actual = primero;
            int contador = 1;

            if (posicion == 1)
            {
                primero = primero.Sig;
                if (primero != null)
                    primero.Ant = null;
                else
                    ultimo = null;

                MessageBox.Show("El nodo en la posición " + posicion + " se eliminó.");
                return;
            }

            while (contador < posicion && actual != null)
            {
                actual = actual.Sig;
                contador++;
            }

            if (actual == null)
            {
                MessageBox.Show("La posición está fuera de rango.");
                return;
            }

            if (actual == ultimo)
            {
                ultimo = ultimo.Ant;
                ultimo.Sig = null;
            }
            else
            {
                actual.Ant.Sig = actual.Sig;
                if (actual.Sig != null)
                    actual.Sig.Ant = actual.Ant;
            }

            MessageBox.Show("El nodo en la posición " + posicion + " fue eliminado.");
        }
    }
}
