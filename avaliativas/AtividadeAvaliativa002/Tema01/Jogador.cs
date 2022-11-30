using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema01
{
    internal class Jogador
    {
        private string camisa, nome;
        private int gols;
        public Jogador(string nome, string camisa, int gols)
        {
            this.camisa = camisa;
            this.nome = nome;
            if (gols >= 0) this.gols = gols;
        }
        public int GetGols()
        {
            return gols;
        }
        public override string ToString()
        {
            return $"Nome: {nome} - Camisa: {camisa} - Gols: {gols}";
        }
    }
}
