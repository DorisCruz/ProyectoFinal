using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
        public class SumarArreglos
        {
            private static Random generador = new Random();
            public static int[] CrearArreglo(int tamaño, int min = 0, int max = 100, int[] arreglo = null, int posicion = 0)
            {
                if (arreglo == null)
                {
                    arreglo = new int[tamaño]; 
                }

                if (posicion == tamaño)
                {
                    return arreglo;
                }

                arreglo[posicion] = generador.Next(min, max);

                return CrearArreglo(tamaño, min, max, arreglo, posicion + 1);
            }

            public static int Sumar(int[] arreglo, int posicion = 0)
            {
                if (posicion == arreglo.Length)
                {
                    return 0;
                }

                return arreglo[posicion] + Sumar(arreglo, posicion + 1);
            }
        }
    }




