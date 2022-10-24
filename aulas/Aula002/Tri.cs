using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    class Tri
    {
        private double b, a;
        public void SetBase(double x)
        {
            if (x > 0) b = x;
        }
        public void SetAltu(double y)
        {
            if (y > 0) a = y; 
        }

        public double GetBase()
        {
            return b;
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
           return  Math.Sqrt(b * b + a * a);
        }
    }
}
