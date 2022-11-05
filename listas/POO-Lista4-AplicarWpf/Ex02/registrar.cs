using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class registrar
    {
        private string nom, tel, ema;
        public registrar(string n, string t, string e)
        {
            if (n != "") nom = n;

            foreach (char caracter in e)
            {
                if (caracter == '@') ema = e;
            }

            int cont = 0;
            foreach (char telef in t)
            {
                switch (telef)
                {
                    case '1': cont += 1; break;
                    case '2': cont += 1; break;
                    case '3': cont += 1; break;
                    case '4': cont += 1; break;
                    case '5': cont += 1; break;
                    case '6': cont += 1; break;
                    case '7': cont += 1; break;
                    case '8': cont += 1; break;
                    case '9': cont += 1; break;
                    case '0': cont += 1; break;
                    default: break;
                }
            }
            if (cont == 9 && t.IndexOf('-') == 5)
            {
                tel = t;
            }

        }
        public override string ToString()
        {
            return $"{nom} - {ema} - {tel}";
        }
    }
}
