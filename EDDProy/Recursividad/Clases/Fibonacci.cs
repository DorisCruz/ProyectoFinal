using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    
   public class Fibonacci
      {
         public int[] Calcular(int n)
         {
            if (n <= 0)
              MessageBox.Show("El número debe ser positivo.");
              int[] resultado = new int[n];
              for (int i = 0; i < n; i++)
              {
                 resultado[i] = FibonacciRecursivo(i);
              }
              return resultado;
         }

         private int FibonacciRecursivo(int n)
            {
              if (n == 0) return 0;
              if (n == 1) return 1;
              return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
            }
        }
    
}
