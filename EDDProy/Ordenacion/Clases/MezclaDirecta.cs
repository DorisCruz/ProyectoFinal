using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    internal class MezclaDirecta
    {
        private int[] numeros;
        public MezclaDirecta()
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

        public void MostrarNumeros(ListBox listBox)
        {
            listBox.Items.Clear(); 
            foreach (int numero in numeros)
            {
                listBox.Items.Add(numero); 
            }
        }

        public void Ordenar(ListBox listBox)
        {
            numeros = MezclarOrdenar(numeros, listBox);
        }

        private int[] MezclarOrdenar(int[] arreglo, ListBox listBox)
        {
            if (arreglo.Length <= 1) 
            {
                return arreglo;
            }

            int mitad = arreglo.Length / 2;
            int[] izquierda = new int[mitad];
            int[] derecha = new int[arreglo.Length - mitad];

            Array.Copy(arreglo, 0, izquierda, 0, mitad);
            Array.Copy(arreglo, mitad, derecha, 0, arreglo.Length - mitad);

            izquierda = MezclarOrdenar(izquierda, listBox);
            derecha = MezclarOrdenar(derecha, listBox);

            int[] resultado = Mezclar(izquierda, derecha);

            numeros = resultado; 
            MostrarNumeros(listBox);

            return resultado;
        }

        private int[] Mezclar(int[] izquierda, int[] derecha)
        {
            int[] resultado = new int[izquierda.Length + derecha.Length];
            int i = 0, j = 0, k = 0;

            while (i < izquierda.Length && j < derecha.Length)
            {
                if (izquierda[i] <= derecha[j])
                {
                    resultado[k++] = izquierda[i++];
                }
                else
                {
                    resultado[k++] = derecha[j++];
                }
            }

            while (i < izquierda.Length)
            {
                resultado[k++] = izquierda[i++];
            }
            while (j < derecha.Length)
            {
                resultado[k++] = derecha[j++];
            }
            return resultado;
        }
    }
}
