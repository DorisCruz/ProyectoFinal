using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class burbujacl
    {
        private int[] numeros; 
        public void GenerarNumeros(int cantidad)
        {
            Random random = new Random();
            numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = random.Next(1, 101);
            }
        }

        public void Ordenar()
        {
            int n = numeros.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }
        }

        public int[] ObtenerNumeros()
        {
            return numeros;
        }
    }
}
