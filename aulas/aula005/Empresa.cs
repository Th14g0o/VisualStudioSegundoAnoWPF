using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula005
{
    class Empresa
    {
        private string nome;
        private Cliente[] vetor = new Cliente[10];
        private int posi = 0;
        private List<Cliente> vetor_formatado = new List<Cliente>();
        public Empresa(string n)
        {
            nome = n;
        }
        public override string ToString()
        {
            //rescreve uma função ja existente, override é um modificador
            return $"Nome da empresa: {nome}";
        }
        public void Inserir(Cliente c)
        {
            vetor[posi] = c;
            posi++;
        }
        //public Cliente[] Listar()
        //{
            //Cliente[] vetor_formatado = new Cliente[posi];
            //Array.Copy(vetor, vetor_formatado, posi);
            //return vetor_formatado;
           
        //}
        public List<Cliente> Listar()
        {
            return vetor_formatado;
        }
    }
}
