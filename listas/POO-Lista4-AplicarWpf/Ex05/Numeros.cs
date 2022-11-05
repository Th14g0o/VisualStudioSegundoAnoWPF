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
        public int[] Calcular(bool? i, bool? p)
        {

            string ns = "";
            int count = 0;

            for (int valor = inicio; valor <= fim; valor++)
            {
                if (i == true && p == true)
                {
                    if (count > 0) ns += " ";
                    ns += valor.ToString();
                    count++;
                }
                else if (i == true && p == false)
                {
                    if (count > 0 && valor % 2 != 0) ns += " ";
                    if (valor % 2 != 0) ns += valor.ToString();
                    count++;
                }
                else
                {
                    if (count > 0 && valor % 2 == 0) ns += " ";
                    if (valor % 2 == 0) ns += valor.ToString();
                    count++;
                }
            }
            count = 0;
            string[] nums = ns.Split();
            int[] interv = new int[nums.Length];
            for (int indice = 0; indice < nums.Length; indice++)
            {
                interv[indice] = int.Parse(nums[indice]);
            }
            return interv;




        }
    }
}
