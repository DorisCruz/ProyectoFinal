using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public class MezclaNatural
    {
        private int[] numeros; 
        public MezclaNatural()
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
            bool ordenado = false;
            while (!ordenado)
            {
                List<int[]> secuencias = DividirEnSecuencias();

                if (secuencias.Count == 1)
                {
                    ordenado = true;
                }
                else
                {
                    numeros = MezclarSecuencias(secuencias);
                    MostrarNumeros(listBox); 
                }
            }
        }

        private List<int[]> DividirEnSecuencias()
        {
            List<int[]> secuencias = new List<int[]>();
            List<int> actual = new List<int>();
            actual.Add(numeros[0]);

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] >= numeros[i - 1]) 
                {
                    actual.Add(numeros[i]);
                }
                else
                {
                    secuencias.Add(actual.ToArray());
                    actual.Clear();
                    actual.Add(numeros[i]);
                }
            }
            secuencias.Add(actual.ToArray());
            return secuencias;
        }

        private int[] MezclarSecuencias(List<int[]> secuencias)
        {
            Queue<int[]> cola = new Queue<int[]>(secuencias);
            while (cola.Count > 1)
            {
                int[] izquierda = cola.Dequeue();
                int[] derecha = cola.Dequeue();

                cola.Enqueue(MezclarDosArreglos(izquierda, derecha));
            }
            return cola.Dequeue();
        }

        private int[] MezclarDosArreglos(int[] izquierda, int[] derecha)
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
