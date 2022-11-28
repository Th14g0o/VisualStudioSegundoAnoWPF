using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Intervalo
    {
        private int inicio, fim;
        public void SetInicio(int v)
        {
            inicio = v;
        }
        public int GetInicio()
        {
            return inicio;
        }
        public void SetFim(int v)
        {
            fim = v;
        }
        public int GetFim()
        {
            return fim;
        }
        public int[] Numeros()
        {


            int indice = 0;

            for (int i = inicio; i <= fim; i++)
            {
                indice++;
            }

            int[] ns = new int[indice];
            indice = 0;

            for (int i = inicio; i <= fim; i++)
            {
                ns[indice] = i;
                indice++;
            }

            return ns;
        }
    }
}
