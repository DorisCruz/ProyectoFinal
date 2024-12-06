﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_No_Lineales;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    class Cola
    {
        private NodoBinario Primero;
        private NodoBinario Ultimo;

        private ListBox list;

        public Cola(ListBox listbox)
        {
            Primero = null;
            Ultimo = null;
            this.list = listbox; 
        }

        public Cola() { }
        public void Queue(NodoBinario nodo)
        {

            if (nodo == null)
                return;

            if (Ultimo == null)
            {
                Primero = nodo;
                Ultimo = nodo;
            }
            else
            {
                Ultimo.Sig = nodo;
                Ultimo = nodo;
            }
            Mostrar();
        }

        public void Mostrar()
        {
            if (list != null)
            {
                list.Items.Clear(); 
                NodoBinario Aux = Primero;
                while (Aux != null)
                {
                    list.Items.Add("[" + Aux.Dato + "]");  
                    Aux = Aux.Sig;
                }
            }
        }

        public NodoBinario DeQueue()
        {
            if (Primero == null)
            {
                MessageBox.Show("Cola vacía");
                return null;
            }
            else
            {
                NodoBinario Aux = Primero;
                Primero = Primero.Sig;
                NodoBinario DATO = Aux;


                if (Primero == null)
                {
                    Ultimo = null; 
                }
                Aux = null;
                Mostrar(); 
                return DATO;

            }
        }
        public void Recorrer(int datoBuscado)
        {
            int posicion = 0;
            NodoBinario Aux = Primero;

            while (Aux != null)
            {
                posicion++;

                if (Aux.Dato == datoBuscado)
                {

                    MessageBox.Show("El dato " + datoBuscado + " está en la posición " + posicion);
                    return; 
                }
                Aux = Aux.Sig; 
            }

            MessageBox.Show("El dato " + datoBuscado + " no se encontro en la cola");
        }

        public void Imprimir()
        {
            if (Primero == null)
            {
                MessageBox.Show("La cola está vacía");
                return;
            }

            NodoBinario Aux = Primero;
            StringBuilder valores = new StringBuilder();

            while (Aux != null)
            {
                valores.Append("[" + Aux.Dato + "] ");
                Aux = Aux.Sig; 
            }

            MessageBox.Show("Valores en la cola: " + valores.ToString());
        }

        public void VaciarCola()
        {
            if (Primero == null)
            { return; }
            else
            {
                NodoBinario Aux;
                while (Primero != null)
                {
                    Aux = Primero; 
                    Primero = Primero.Sig;  
                    Aux = null;  
                }
                Primero = null;
                Ultimo = null;

            }
            Mostrar();
        }
        public bool IsEmpty()
        {
            return Primero == null;
        }
    }

}

