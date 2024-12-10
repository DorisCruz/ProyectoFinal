using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Hash
    {
        private int[] tablaHash; 
        private int tamañoTabla;

        public Hash(int tamaño)
        {
            tamañoTabla = tamaño;
            tablaHash = new int[tamañoTabla];

            for (int i = 0; i < tamañoTabla; i++)
            {
                tablaHash[i] = -1;
            }
        }

        public void Insertar(int[] numeros)
        {
            foreach (int numero in numeros)
            {
                int posicion = FuncionHash(numero);

                while (tablaHash[posicion] != -1)
                {
                    posicion = (posicion + 1) % tamañoTabla;
                }
                tablaHash[posicion] = numero;
            }
        }

        public int? Buscar(int numero)
        {
            int posicion = FuncionHash(numero);
            int contador = 0; 
            while (tablaHash[posicion] != -1 && contador < tamañoTabla)
            {
                if (tablaHash[posicion] == numero)
                {
                    return posicion; 
                }
                posicion = (posicion + 1) % tamañoTabla;
                contador++;
            }

            return null;
        }

        private int FuncionHash(int numero)
        {
            return numero % tamañoTabla;
        }

        public string MostrarTabla()
        {
            string resultado = "";
            for (int i = 0; i < tamañoTabla; i++)
            {
                resultado += $"Posición {i}: {(tablaHash[i] == -1 ? "Vacío" : tablaHash[i].ToString())}\n";
            }
            return resultado;
        }

    }
}

