using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    internal class Numeros
    {
        private int inicio, fim;
        public Numeros(int i, int f)
        {
            if (i < f)
            {
                inicio = i;
                fim = f;
            }
            else
            {
                inicio = f;
                fim = i;
            }
       
        }
        public int[] Calcular(bool i, bool p)
        {
            int[] lista = new int[fim - inicio]; 
            if (i == true && p == true)
            {
                for (int ni = inicio; ni <= fim; ni++)
                {
                    lista[ni - 1] = ni;
                }
            }
            else if (i == true)
            {
                for (int ni = inicio; ni <= fim; ni++)
                {
                    if (ni%2 != 0) lista[ni - 1] = ni;
                }
            }
            else
            {
                for (int ni = inicio; ni <= fim; ni++)
                {
                    if (ni % 2 == 0) lista[ni - 1] = ni;
                }
            }
            return lista;
        }
    }
}
