using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    internal class BusquedaBinaria
    {
        private int[] numeros;
        public BusquedaBinaria()
        {
            numeros = new int[0];
        }

        public void GenerarNumeros(int cantidad)
        {
            Random random = new Random();
            numeros = new int[cantidad];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 101); 
            }

            Quicksort(numeros, 0, numeros.Length - 1); 
        }

        private void Quicksort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                Quicksort(arr, low, pivotIndex - 1);
                Quicksort(arr, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }

        public int Buscar(int objetivo)
        {
            int inicio = 0, fin = numeros.Length - 1;

            while (inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;

                if (numeros[medio] == objetivo)
                    return medio;

                if (numeros[medio] < objetivo)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }
           return -1;
        }

        public int[] ObtenerNumeros()
        {
            return numeros;
        }
        public void MostrarNumeros(ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (int numero in numeros)
            {
                listBox.Items.Add(numero); 
            }
        }
    }
}
