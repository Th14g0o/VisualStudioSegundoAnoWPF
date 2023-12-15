using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Frete
    {
        private double peso, distancia;
        public Frete(double peso, double distancia)
        {
            if (peso >= 0) this.peso = peso;
            if (distancia >= 0) this.distancia = distancia;
        }
        public void SetPeso(double peso)
        {
            if (peso >= 0) this.peso = peso;
        }
        public double GetPeso()
        {
            return peso;
        }
        public void SetDistancia(double distancia)
        {
            if (distancia >= 0) this.distancia = distancia;
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public double CalcArea()
        {
            return peso / distancia;
        }
        public override string ToString()
        {
            return $"Peso: {peso}\nDistancia: {distancia}";
        }
    }
}
