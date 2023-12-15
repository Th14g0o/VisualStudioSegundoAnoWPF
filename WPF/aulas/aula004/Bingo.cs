using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula004
{
    internal class Bingo
    {
        private int numBolas, index;
        private int[] Numeros;
        public void Iniciar(int numBolas)
        {
            Random substituto = new Random();
            if (numBolas >= 10 && numBolas <= 100)
                this.numBolas = numBolas;
            else
                this.numBolas = substituto.Next(10, 101);
            Numeros = new int[numBolas];
            index = 0;
        }
        public int Proximo()
        {
            if (index == numBolas) return -1;
            Random valor = new Random();

            int bola1 = valor.Next(1, numBolas + 1);
            int verifica = Array.IndexOf(Numeros, bola1);

            while (verifica != -1)
            {
                bola1 = valor.Next(1, numBolas + 1);
                verifica = Array.IndexOf(Numeros, bola1);
            }
            Numeros[index] = bola1;
            index++;
            return bola1;
        }
        public int[] Sorteados()
        {
            int[] vetor = new int[index];
            Array.Copy(Numeros, vetor, index);
            Array.Sort(vetor);
            return vetor;
        }
    }
}
