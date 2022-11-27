using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Equacao
    {
        private double a, b, c;
        public Equacao(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void SetABC(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }
        public bool RaizesReais(out double x1, out double x2)
        {
            if (Delta() >= 0)
            {
                x1 = (b * -1 + Delta()) / (2 * a);
                x2 = (b * -1 + Delta()) / (2 * a);
                return true;
            }
            x1 = 0;
            x2 = 0;
            return false;
          
        }
        public double Delta()
        {
            return b * b - 4 * a * c;
        }
        public override string ToString()
        {
            return $"A = {a} - B = {b} - C = {c}";
        }


    }
}
