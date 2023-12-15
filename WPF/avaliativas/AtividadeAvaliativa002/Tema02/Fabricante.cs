using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Tema02
{
    internal class Fabricante
    {
        private string nome, sigla;
        private Veiculo[] veiculos = new Veiculo[10];
        private int indice = 0;
        public Fabricante(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }
        public override string ToString()
        {
            return $"{nome}({sigla})";
        }
        public void Inserir(Veiculo v)
        {
            if (indice == veiculos.Length)
                Array.Resize(ref veiculos, veiculos.Length * 2);
            veiculos[indice] = v;
            indice++;
        }
        public Veiculo[] Listar()
        {
            Veiculo[] vs = new Veiculo[indice];
            Array.Copy(veiculos, vs, indice);
            return vs;
        }
        public Veiculo MaiorPreco()
        {
            double[] maior = new double[indice];
            for (int i = 0; i < indice; i++)
                maior[i] = Listar()[i].GetPreco();
            Array.Sort(maior);
            Array.Reverse(maior);


            for (int i = 0; i < indice; i++)
            {
                double v1 = maior[i];
                for (int i2 = 0; i2 < indice; i2++)
                {
                    double v2 = Listar()[i2].GetPreco();
                    if (v2 == v1)
                        return Listar()[i2];
                }
            }
            return Listar()[0];

        }
    }
}
