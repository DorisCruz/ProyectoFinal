using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public class Nodo
    {
        public string Dato { get; set; }
        public Nodo Siguiente { get; set; }
    }

    public class Listas
    {
        private Nodo Inicio;
        private Nodo Fin;
        private ListBox listashow;

        public Listas(ListBox listashow)
        {
            Inicio = null;
            Fin = null;
            this.listashow = listashow;

        }

        public void Insertar(int posicion, string dato)
        {
            Nodo nuevo = new Nodo { Dato = dato, Siguiente = null };

            if (Inicio == null && Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
            }
            else if (posicion == 0 || posicion == 1)
            {
                nuevo.Siguiente = Inicio;
                Inicio = nuevo;
            }
            else
            {
                int pos = 1;
                Nodo aux = Inicio;
                Nodo previo = null;

                while (pos < posicion && aux != null)
                {
                    previo = aux;
                    aux = aux.Siguiente;
                    pos++;
                }

                if (aux != null)
                {
                    nuevo.Siguiente = aux;
                    previo.Siguiente = nuevo;
                }
                else
                {
                    Fin.Siguiente = nuevo;
                    Fin = nuevo;
                }
            }
        }

        public int Buscar(string dato)
        {
            if (Inicio == null) return -1;

            Nodo actual = Inicio;
            int posicion = 1;

            while (actual != null)
            {
                if (actual.Dato == dato) return posicion;

                actual = actual.Siguiente;
                posicion++;
            }

            return -1;
        }

        public void Eliminar(string dato)
        {
            if (Inicio == null) return;

            if (Inicio.Dato == dato)
            {
                Inicio = Inicio.Siguiente;
                if (Inicio == null) Fin = null;
                return;
            }

            Nodo actual = Inicio;
            Nodo previo = null;

            while (actual != null && actual.Dato != dato)
            {
                previo = actual;
                actual = actual.Siguiente;
            }

            if (actual != null)
            {
                previo.Siguiente = actual.Siguiente;
                if (actual == Fin) Fin = previo;
            }
        }

        public Nodo ObtenerInicio()
        {
            return Inicio;
        }

        public void ActualizarLista()
        {
            if(listashow != null)
            {
                listashow.Items.Clear();
                Nodo Aux = Inicio;
                while (Aux != null)
                {
                    listashow.Items.Add(Aux.Dato);
                    Aux = Aux.Siguiente;


                }
             
            }
        }
        public void Vaciar()
        {
            Inicio = null;
            Fin = null;
            if (listashow != null)
            {
                listashow.Items.Clear(); 
            }
        }
    }
}
