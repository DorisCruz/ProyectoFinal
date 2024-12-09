using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class IntercalacionClas
    {
        private int[] numeros; 

        public IntercalacionClas()
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
        }

        public int[] ObtenerNumeros()
        {
            return numeros;
        }

        public void Ordenar(Action<int[]> mostrarArreglo)
        {
            MergeSort(numeros, mostrarArreglo);
        }

        private void MergeSort(int[] arreglo, Action<int[]> mostrarArreglo)
        {
            if (arreglo.Length <= 1) return;

            int mitad = arreglo.Length / 2;
            int[] izquierda = arreglo.Take(mitad).ToArray();
            int[] derecha = arreglo.Skip(mitad).ToArray();

            MergeSort(izquierda, mostrarArreglo);
            MergeSort(derecha, mostrarArreglo);

            int i = 0, j = 0, k = 0;

            while (i < izquierda.Length && j < derecha.Length)
            {
                if (izquierda[i] < derecha[j])
                {
                    arreglo[k] = izquierda[i];
                    i++;
                }
                else
                {
                    arreglo[k] = derecha[j];
                    j++;
                }
                k++;
            }

            while (i < izquierda.Length)
            {
                arreglo[k] = izquierda[i];
                i++;
                k++;
            }

            while (j < derecha.Length)
            {
                arreglo[k] = derecha[j];
                j++;
                k++;
            }
            mostrarArreglo(arreglo);
        }
    }
}
