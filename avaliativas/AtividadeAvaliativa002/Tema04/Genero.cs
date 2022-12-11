using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema04
{
    internal class Genero
    {
        private string nome = "";
        private Livro[] livros = new Livro[10];
        private int indice = 0;
        public Genero(string nome)
        {
            if (nome != "") this.nome = nome;
        }
        public void SetNome(string nome)
        {
            if (nome != "") this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void Inserir(Livro l)
        {
            if (indice == livros.Length)
                Array.Resize(ref livros, livros.Length + 10);
            livros[indice] = l;
            indice++;
        }
        public Livro[] Listar()
        {
            Livro[] livros = new Livro[indice];
            Array.Copy(this.livros, livros, indice);
            return livros;
        }
        public Livro MenorPreco()
        {
            double[] valores = new double[indice];
            for (int i = 0; i < indice; i++)
                valores[i] = Listar()[i].GetPreco();
            Array.Sort(valores);

            Livro l = Listar()[0];

            for (int i = 0; i < indice; i++)
            {
                if (valores[0] == Listar()[i].GetPreco())
                {
                    l = Listar()[i];
                    break;
                }                           
            }
            return l;
        }
        public override string ToString()
        {
            return $"Genero : {nome}";
        }
    }
}
