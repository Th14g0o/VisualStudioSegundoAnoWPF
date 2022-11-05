using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Abastecimento
    {
        private double km, litros, valor;

        public void SetValorPago(double v)
        {
            if (v >= 0) valor = v;
        }
        public void SetValorLitro(double l)
        {
            if (l >= 0) litros = l;
        }
        public void SetKmRodados(double k)
        {
            if (k >= 0) km = k;
        }

        public double CalcKmLitro()
        {
            return km / litros;
        }
        public double CalcReaisKm()
        {
            return valor / km;
        }
    }
}
