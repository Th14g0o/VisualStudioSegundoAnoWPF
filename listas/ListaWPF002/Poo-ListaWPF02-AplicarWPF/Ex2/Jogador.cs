using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Ex2
{
    internal class Jogador
    {
        private string nome = "";
        private int gols;
        private int indice = 0;
        private Jogador[] jogadores = new Jogador[16];

        public void SetNome(string n)
        {
            nome = n;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetGols(int g)
        {
            if (g >= 0) gols = g;
        }
        public int GetGols()
        {
            return gols;
        }
        public void Inserir(Jogador j)
        {
            if (indice == jogadores.Length)
                Array.Resize(ref jogadores, indice * 2);
            jogadores[indice] = j;
            indice++;
        }

        public Jogador[] Listar() 
        {
            Jogador[] vetor = new Jogador[indice];
            Array.Copy(jogadores, vetor, indice);

            int[] maiores = new int[indice];    
            for (int i = 0; i < indice; i++)
            {
                maiores[i] = vetor[i].GetGols();
            }
            Array.Sort(maiores);
            Array.Reverse(maiores);

            int posi;
            int[] posis = new int[indice];
            for (int i = 0; i < indice; i++)
            {
                posis[i] = -500;
            }
            int cont = 0;
            for (int i = 0; i < indice; i++)
            {
                int v = maiores[i];
                for (int i2 = 0; i2 < indice; i2++)
                {
                    int g = vetor[i2].GetGols();
                    posi = i2;
                    if (v == g)
                    {
                        if (Array.IndexOf(posis, posi) == -1)
                        {
                            posis[cont] = posi;
                            cont++;
                            break;
                        }
                        else
                        {
                            posis[cont] = posi;
                        }

                    }
                }
                    
            }

            Jogador[] organizado = new Jogador[indice];
            for (int i = 0; i < indice; i++)
            {
                organizado[i] = vetor[posis[i]];
            }

            return organizado;
        }
    }
}
