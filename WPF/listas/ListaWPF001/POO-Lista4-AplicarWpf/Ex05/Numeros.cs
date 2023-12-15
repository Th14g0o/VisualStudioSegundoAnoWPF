using System;
using System.Collections.Generic;
using System.Globalization;
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
            int tam = fim;
            if (inicio == 0) tam++;
            if (inicio < 0) tam += Math.Abs(inicio) + 2;
            int count = 0;
            int[] todos = new int[tam];

            for (int valor = inicio; valor <= fim; valor++)
            {
                if (i == true && p == true)
                {
                    todos[count] = valor;
                    count++;
                }
                else if (i == true && p == false)
                {
                    if (valor % 2 != 0)
                    {
                        todos[count] = valor;
                        count++;
                    }
                }
                else
                {
                    if (valor % 2 == 0)
                    {
                        todos[count] = valor;
                        count++;
                    }
                }
            }
            int[] interv = new int[count];
            Array.Copy(todos, interv, count);
            return interv;




        }
    }
}
