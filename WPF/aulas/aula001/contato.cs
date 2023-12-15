using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula001
{
    internal class contato
    {
        private string n, t, e;
        public contato(string nom, string tel, string ema)
        {
            if (nom != "") n = nom;
            if (tel != "") t = tel;
            if (ema != "") e = ema;
        }
        public override string ToString()
        {
            return $"{n} - {e} - {t}";
        }
    }
}
