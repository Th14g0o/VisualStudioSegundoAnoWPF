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
            //if (indice == jogadores.Length)
                //Array.Resize(ref jogadores, jogadores.Length + 11);
            jogadores[indice] = j;
            indice++;
        }
        public Jogador[] Listar()
        {
            Jogador[] vetor = new Jogador[indice];
            Array.Copy(jogadores, vetor, indice);
            return vetor;
        }
        public Jogador Artilheiro()
        {

            int[] maiores = new int[indice];
            for (int i = 0; i < indice; i++)
                maiores[i] = Listar()[i].GetGols();
            Array.Sort(maiores);
            Array.Reverse(maiores);

            //Jogador jota = Listar()[0];
            //for (int i2 = 0; i2 < indice; i2++)
            //{
                //int jg = Listar()[i2].GetGols();
                //if (maiores[0] == jg)
                    //jota = Listar()[i2];
            //}
            //return jota;

            int quant = 0;
            for (int i2 = 0; i2 < indice; i2++)
            {
                int v2 = maiores[i2];
                if (maiores[0] == v2)
                    quant++;         
            }

            Jogador[] j = new Jogador[quant];
            int count = 0;
            for (int i2 = 0; i2 < indice; i2++)
            {
                int jg = Listar()[i2].GetGols();
                if (maiores[0] == jg)
                {
                    j[count] = Listar()[i2];
                    count++;
                }
            }

            Random intervalo = new Random();

            return j[intervalo.Next(0, quant)];
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
