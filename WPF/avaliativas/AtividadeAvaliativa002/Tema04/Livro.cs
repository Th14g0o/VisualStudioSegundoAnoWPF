using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema04
{
    internal class Livro
    {
        private string nome  = "-1", autor = "-1";
        private double preco = -1.0;
        public Livro(string nome, string autor, double preco)
        {
            if (nome != "") this.nome = nome;
            if (autor != "") this.autor = autor;
            if (preco >= 0) this.preco = preco;
        }
        public void SetNome(string n)
        {
            if (n != "") nome = n;
        }
        public void SetAutor(string a)
        {
            if (a != "") autor = a;
        }
        public void SetPreco(double p)
        {
            if (p >= 0) preco = p;
        }
        public double GetPreco()
        {
            return preco;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetAutor()
        {
            return autor;
        }
  
        public override string ToString()
        {
            return $"Nome: {nome} | Autor: {autor} | Preço: {preco:0.00}";
        }

    }
}
