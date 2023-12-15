using System;
using System.Collections.Generic;
using System.Text;

namespace AreaDoTriangulo
{
    static class Fator
    {
        public static double Num { get; set; }
        public static double Fatorial()
        {
            double x = 1;
            if (Num == 0)
                return x = 0;
            for (int i = 1; i <= Num; i++)
            {
                x *= i;
            }
            return x;
        }
    }
}
