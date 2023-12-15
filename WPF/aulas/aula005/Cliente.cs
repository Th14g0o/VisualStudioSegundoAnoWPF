using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula005
{
    class Cliente
    {
        private string nome;
        private double limite;

        public Cliente(string n, double l)
        {
            nome = n;
            if (l > 0) limite = l;
        }
        public override string ToString()
        {
            return $"Nome do cliente: {nome}\nLimite: {limite}";
        }
    }
}
