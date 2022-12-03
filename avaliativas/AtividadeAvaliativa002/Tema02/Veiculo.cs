using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema02
{
    internal class Veiculo
    {
        private string nome, modelo;
        private double preco;

        public Veiculo(string nome, string modelo, double preco)
        {
            this.nome = nome;
            this.modelo = modelo;
            if (preco >= 0) this.preco = preco;
        }
        public double GetPreco()
        {
            return preco;
        }
        
        public override string ToString()
        {
            return $"Modelo: {modelo} - Nome: {nome} - Preço: R$ {preco:0.00}";
        }
    }
}
