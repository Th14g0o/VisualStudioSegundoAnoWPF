using System;
using System.Collections.Generic;
using System.Text;

namespace AreaDoTriangulo
{
    static class Trian
    {
        public static double Altu { get; set; }
        public static double Base { get; set; }
        public static double Area()
        {
            return (Base * Altu) / 2;
        }
        
    }
}
