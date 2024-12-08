using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Exponentes
    {
        public double Calcular(double baseNumero, int exponente)
        {
            if (exponente == 0)
                return 1;
            if (exponente < 0)
                return 1 / Calcular(baseNumero, -exponente);
            return baseNumero * Calcular(baseNumero, exponente - 1);
        }
    }
}
