using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ex03
{
    internal class retangulo
    {
        private double b, a;
        public void SetBase(double ba)
        {
            if (ba > 0) b = ba;
        }
        public double GetBase()
        {
            return b;
        }
        public void SetAltu(double al)
        {
            if (al > 0) a = al;
        }
        public double GetAltu()
        {
            return a;
        }
        public double CalcArea()
        {
            return b * a;
        }
        public double CalcDiag()
        {
            return Math.Sqrt(b * b + a * a);
        }
    }

}
