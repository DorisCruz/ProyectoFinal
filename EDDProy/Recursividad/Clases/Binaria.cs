using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Binaria
    {
      
            public int Buscar(int[] arreglo, int objetivo, int inicio = 0, int fin = -1)
            {
            if (fin == -1)
            {
                fin = arreglo.Length - 1;
            }

            // Condición base: si los límites son inválidos, retornar -1
            if (inicio > fin)
            {
                return -1;
            }

            // Calcular el índice del punto medio
            int medio = inicio + (fin - inicio) / 2;

            // Si encontramos el elemento, devolver índice
            if (arreglo[medio] == objetivo)
            {
                return medio;
            }

            // Buscar en la mitad izquierda
            if (arreglo[medio] > objetivo)
            {
                return Buscar(arreglo, objetivo, inicio, medio - 1);
            }

            // Buscar en la mitad derecha
            return Buscar(arreglo, objetivo, medio + 1, fin);
        }
    
    }
}
