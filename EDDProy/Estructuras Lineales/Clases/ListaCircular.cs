using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EDDemo
{
    public class ListaCircular
    {
        private Nodo primero;
        private Nodo ultimo;

        public ListaCircular()
        {
            primero = null;
            ultimo = null;
        }

        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (primero == null)
            {
                primero = nuevo;
                primero.Sig = primero; // Se apunta a sí mismo
                ultimo = primero;
            }
            else
            {
                ultimo.Sig = nuevo;
                nuevo.Sig = primero;
                ultimo = nuevo;
            }
        }

        public void VerLista(ListBox list, bool derechaIzquierda)
        {
            list.Items.Clear();

            if (primero == null)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            Nodo actual;
            if (derechaIzquierda)
            {
                // Recorrer en sentido inverso no es trivial en listas circulares sin un enlace "Atrás".
                MessageBox.Show("Recorrido derecha a izquierda no implementado.");
            }
            else
            {
                actual = primero;
                do
                {
                    list.Items.Add(actual.Dato.ToString());
                    actual = actual.Sig;
                } while (actual != primero);
            }
        }

        public int Buscar(int dato)
        {
            if (primero == null)
            {
                return -1;
            }

            Nodo actual = primero;
            int posicion = 1;

            do
            {
                if (actual.Dato == dato)
                {
                    return posicion;
                }
                actual = actual.Sig;
                posicion++;
            } while (actual != primero);

            return -1;
        }

        public void VaciarLista(ListBox list)
        {
            primero = null;
            ultimo = null;
            list.Items.Clear();
        }

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
                if (primero == ultimo)
                {
                    primero = null;
                    ultimo = null;
                }
                else
                {
                    ultimo.Sig = primero.Sig;
                    primero = primero.Sig;
                }
            }
            else
            {
                while (contador < posicion - 1 && actual.Sig != primero)
                {
                    actual = actual.Sig;
                    contador++;
                }

                if (actual.Sig == primero || actual.Sig == null)
                {
                    MessageBox.Show("Posición fuera de rango.");
                    return;
                }

                Nodo nodoAEliminar = actual.Sig;
                actual.Sig= nodoAEliminar.Sig;

                if (nodoAEliminar == ultimo)
                {
                    ultimo = actual;
                }
            }

            MessageBox.Show("El nodo en la posición " + posicion + " se eliminó.");
        }
    }

}
