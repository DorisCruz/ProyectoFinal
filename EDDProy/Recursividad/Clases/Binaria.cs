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

            if (inicio > fin)
            {
                return -1; 
            }
            int medio = inicio + (fin - inicio) / 2; 

            if (arreglo[medio] == objetivo)
            {
                return medio; 
            }

            if (arreglo[medio] > objetivo)
            {
                return Buscar(arreglo, objetivo, inicio, medio - 1);
            }

            return Buscar(arreglo, objetivo, medio + 1, fin);
        }
    
    }
}
