using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema03
{
    internal class Estado
    {
        private string nome, sigla;
        private int populacao;
        public Estado(string nome, string sigla, int populacao)
        {
            this.nome = nome;
            this.sigla = sigla;
            if (populacao >= 0) this.populacao = populacao;
        }
        public override string ToString()
        {
            return $"{nome}({sigla}) - {populacao} habitantes";
        }
        public int GetPopulacao()
        {
            return populacao;
        }
    }
}
