using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema01
{
    internal class Time
    {
        private string nome, estado;
        private Jogador[] jogadores = new Jogador[22];
        private int indice = 0;

        public void Inserir(Jogador j)
        {
            jogadores[indice] = j;
            indice++;
        }
        public Jogador[] Listar()
        {
            Jogador[] vetor = new Jogador[indice];
            Array.Copy(jogadores, vetor, indice);
            return vetor;
        }
        public Jogador[] Artilheiro()
        {
            Jogador[] vetor = new Jogador[indice];
            Array.Copy(jogadores, vetor, indice);

            int[] maiores = new int[indice];
            for (int i = 0; i < indice; i++)
                maiores[i] = vetor[i].GetGols();
            Array.Sort(maiores);
            Array.Reverse(maiores);


            int quant = 0;
            for (int i = 0; i < indice; i++)
            {
                int v1 =maiores[i];
                for (int i2 = 0; i2 < indice; i2++)
                {
                    int v2 = maiores[i2];
                    if (v1 == v2)
                        quant++;
             
                }
                break;
            }

            int[] posis = new int[quant];
            for (int i = 0; i < quant; i++)
                posis[i] = -500;

            Jogador[] j = new Jogador[quant];

            for (int i = 0; i < quant; i++)
            {
                int v1 = maiores[i];
                for (int i2 = 0; i2 < indice; i2++)
                {
                    int jg = vetor[i2].GetGols();
                    if (v1 == jg && Array.IndexOf(posis, i2) == -1)
                    {
                        j[i] = vetor[i2];
                        posis[i] = i2;
                        break;
                    }
                    else
                        j[i] = vetor[i2];
                }
            }

            return j;
        }

        public Time(string nome, string estado)
        {
            this.nome = nome;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"{nome} - {estado}";
        }

    }
}
