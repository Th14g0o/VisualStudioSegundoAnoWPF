using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema03
{
    internal class Pais
    {
        private string nome;
        private double area;
        private Estado[] estados = new Estado[10];
        private int indice = 0;
        public Pais(string nome, double area)
        {
            this.nome = nome;
            this.area = area;
        }
        public override string ToString()
        {
            return $"{nome}";
        }
        public void Inserir(Estado e)
        {
            if (indice == estados.Length)
                Array.Resize(ref estados, estados.Length * 2);
            estados[indice] = e;
            indice++;
        }
        public Estado[] Listar()
        {
            Estado[] e = new Estado[indice];
            Array.Copy(estados, e, indice);
            return e;
        }
        public int Populacao()
        {
            int soma = 0;
            foreach (Estado e in Listar())
                soma += e.GetPopulacao();
            return soma;
        }
    }
}
