using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Shellsort
    {

        private int[] numeros; // Arreglo para almacenar los números generados.

        public Shellsort()
        {
            numeros = new int[0]; // Inicializa el arreglo vacío.
        }

        // Método para generar números aleatorios con una cantidad específica.
        public void GenerarNumeros(int cantidad)
        {
            Random random = new Random();
            numeros = new int[cantidad]; // Redimensiona el arreglo según la cantidad especificada.

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 101); // Genera números entre 1 y 100.
            }
        }

        // Método para ordenar los números con el algoritmo ShellSort.
        public void Ordenar(Action<int[]> mostrarArreglo)
        {
            int n = numeros.Length;
            int gap = n / 2; // Empieza con un gap grande.

            while (gap > 0)
            {
                // Hacer una pasada por todos los elementos del arreglo
                for (int i = gap; i < n; i++)
                {
                    int temp = numeros[i];
                    int j = i;

                    // Compara los elementos separados por el gap
                    while (j >= gap && numeros[j - gap] > temp)
                    {
                        numeros[j] = numeros[j - gap];
                        j -= gap;
                    }

                    numeros[j] = temp;
                }

                gap /= 2; // Reduce el gap para la siguiente pasada

                // Mostrar el progreso del arreglo en cada iteración del gap
                mostrarArreglo(numeros);
            }
        }

        // Método para obtener el arreglo de números.
        public int[] ObtenerNumeros()
        {
            return numeros;
        }
    }
}
