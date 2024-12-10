using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Quicksort
    {
        private int[] numeros; 
        public Quicksort()
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

        public void Ordenar()
        {
            QuickSortRecursivo(numeros, 0, numeros.Length - 1);
        }

        private void QuickSortRecursivo(int[] arreglo, int bajo, int alto)
        {
            if (bajo < alto)
            {
                int p = Particionar(arreglo, bajo, alto);
                QuickSortRecursivo(arreglo, bajo, p - 1); 
                QuickSortRecursivo(arreglo, p + 1, alto);
            }
        }

        private int Particionar(int[] arreglo, int bajo, int alto)
        {
            int pivote = arreglo[alto];
            int i = bajo - 1; 

            for (int j = bajo; j < alto; j++)
            {
                if (arreglo[j] <= pivote) 
                {
                    i++;
                   
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                }
            }

            int temp2 = arreglo[i + 1];
            arreglo[i + 1] = arreglo[alto];
            arreglo[alto] = temp2;

            return i + 1; 
        }
        public int[] ObtenerNumeros()
        {
            return numeros;
        }
    }
}
