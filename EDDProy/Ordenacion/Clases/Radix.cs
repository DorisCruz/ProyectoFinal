using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Radix
    {
        public int[] numeros; 
        public Radix()
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
            int max = numeros.Max();
            int exp = 1; 

            while (max / exp > 0)
            {
                SortPorDigito(exp, mostrarArreglo);
                exp *= 10; 
            }
        }
        private void SortPorDigito(int exp, Action<int[]> mostrarArreglo)
        {
            int[] output = new int[numeros.Length]; 
            int[] count = new int[10]; 

            for (int i = 0; i < numeros.Length; i++)
            {
                int digit = (numeros[i] / exp) % 10;
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                int digit = (numeros[i] / exp) % 10;
                output[count[digit] - 1] = numeros[i];
                count[digit]--;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = output[i];
            }
            mostrarArreglo(numeros);
        }
    }
}
