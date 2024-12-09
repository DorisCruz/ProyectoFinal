using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Quicksort
    {

        private int[] numeros; // Arreglo para almacenar los números.

        // Constructor
        public Quicksort()
        {
            numeros = new int[0]; // Inicializa el arreglo vacío.
        }

        // Método para generar números aleatorios con una cantidad específica.
        public void GenerarNumeros(int cantidad)
        {
            Random random = new Random();
            numeros = new int[cantidad]; // Redimensiona el arreglo.

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 101); // Genera números entre 1 y 100.
            }
        }

        // Método para ordenar los números usando el algoritmo QuickSort.
        public void Ordenar()
        {
            QuickSortRecursivo(numeros, 0, numeros.Length - 1);
        }

        // Método recursivo de QuickSort
        private void QuickSortRecursivo(int[] arreglo, int bajo, int alto)
        {
            if (bajo < alto)
            {
                int p = Particionar(arreglo, bajo, alto); // Encuentra el índice de partición.
                QuickSortRecursivo(arreglo, bajo, p - 1); // Ordena el lado izquierdo.
                QuickSortRecursivo(arreglo, p + 1, alto); // Ordena el lado derecho.
            }
        }

        // Método para particionar el arreglo.
        private int Particionar(int[] arreglo, int bajo, int alto)
        {
            int pivote = arreglo[alto]; // Tomamos el último elemento como pivote.
            int i = bajo - 1; // Índice del elemento más pequeño.

            for (int j = bajo; j < alto; j++)
            {
                if (arreglo[j] <= pivote) // Si el elemento es menor o igual que el pivote
                {
                    i++;
                    // Intercambiamos elementos
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                }
            }

            // Intercambiamos el pivote con el elemento en la posición i + 1
            int temp2 = arreglo[i + 1];
            arreglo[i + 1] = arreglo[alto];
            arreglo[alto] = temp2;

            return i + 1; // Retorna el índice de partición.
        }

        // Método para obtener el arreglo de números.
        public int[] ObtenerNumeros()
        {
            return numeros;
        }

    }
}
