using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class EquacaoIIGrau
    {
        private double a1, b1, c1;
        public void SetABC(double ca, double cb, double cc)
        {
            if (ca != 0) a1 = ca;
            b1 = cb;
            c1 = cc;
        }
        public void GetABC(out double ca, out double cb, out double cc)
        {
            ca = a1;
            cb = b1;
            cc = c1;
        }
        public double CalcDelta()
        {
            return b1 * b1 -4*a1*c1;
        }
        public bool RaizesReais()
        {
            if (CalcDelta() < 0 || a1 == 0) return false;
            return true;
        }
        public bool X1(out double x)
        {
            if (CalcDelta() < 0 || a1 == 0)
            {
                x = 0;
                return false;
            }
            x = (b1 * -1 + Math.Sqrt(CalcDelta())) / (2 * a1);
            return true;
        }
        public bool X2(out double x)
        {
            if (CalcDelta() < 0 || a1 == 0)
            {
                x = 0;
                return false;
            }

            x = (b1 * -1 - Math.Sqrt(CalcDelta())) / (2 * a1);
            return true;
        }
    }
}
