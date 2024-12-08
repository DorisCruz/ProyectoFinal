using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Factorialclass
    {
        public int Calcular(int numero)
        {
            // Caso base
            if (numero <= 1)
                return 1;
            // Recursión
            return numero * Calcular(numero - 1);
        }
    }
}
