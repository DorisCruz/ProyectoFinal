using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    internal class Hanoi
    {
        public List<string> Movimientos { get; private set; }

        public Hanoi()
        {
            Movimientos = new List<string>();
        }

        public void Resolver(int discos, string origen, string destino, string auxiliar)
        {
            if (discos == 1)
            {
                Movimientos.Add($"Mover disco de {origen} a {destino}");
            }
            else
            {
                Resolver(discos - 1, origen, auxiliar, destino);
                Movimientos.Add($"Mover disco de {origen} a {destino}");
                Resolver(discos - 1, auxiliar, destino, origen);
            }
        }
    }
}
