using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraDoWindows
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadorazona : ContentPage
    {
        public Calculadorazona()
        {
            InitializeComponent();
        }
        private double conta = 0, valN = 0;
        private string n = "0";
        private bool primeira = true, soma = false, subt = false, mult = false, divi = false;


        private void Calculo(Object sender, EventArgs e)
        {

            Button b = (Button)sender;
           
            valN = double.Parse(n);
            n = "0";

            switch (b.Text)
            {
                case "+": conta += valN; soma = true; subt = false; mult = false; divi = false; break;
                case "-": conta += valN; soma = false; subt = true; mult = false; divi = false; break; 
            }


            if (b.Text == "*" && primeira == true)
            {
                conta += valN; soma = false; subt = false; mult = true; divi = false;  
            }
            if (b.Text == "*" && primeira == false)
            {
                conta *= valN; soma = false; subt = false; mult = true; divi = false;
            }




            if (b.Text == "/" && primeira == true)
            {
                conta += valN; soma = false; subt = false; mult = false; divi = true; 
            }
            if (b.Text == "/" && primeira == false)
            {
                conta /= valN; soma = false; subt = false; mult = false; divi = true;
            }


            if (b.Text == "=" && soma == true)
            {
                conta += valN;
                Valor.Text = conta.ToString();
                soma = false;
            }
            if (b.Text == "=" && subt == true)
            {
                conta -= valN;
                Valor.Text = conta.ToString();
                subt = false;
            }
            if (b.Text == "=" && mult == true && primeira == false)
            {
                conta *= valN;
                Valor.Text = conta.ToString();
                mult = false;
            }
            if (b.Text == "=" && divi == true && primeira == false)
            {
                conta /= valN;
                Valor.Text = conta.ToString();
                divi = false;
            }
            if (b.Text == "=")
            {
                n = "0";
                primeira = true;
 
            }
            else
            {
                primeira = false;
            }
        }

        private void Atribuir(Object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (n == "0" && primeira == true)
            {
                conta = 0;
            }
            if (n == "0")
            {
               n = b.Text;
            }
            else
            {
                switch (b.Text)
                {
                    case "0": n += "0"; break;
                    case "1": n += "1"; break;
                    case "2": n += "2"; break;
                    case "3": n += "3"; break;
                    case "4": n += "4"; break;
                    case "5": n += "5"; break;
                    case "6": n += "6"; break;
                    case "7": n += "7"; break;
                    case "8": n += "8"; break;
                    case "9": n += "9"; break;
                }
            }
            if (primeira == true)
                Valor.Text = n;


        }

        private void Limpar(Object sender, EventArgs e)
        {
            n = "0";
            Valor.Text = "";
            primeira = true;
            conta = 0; 
            valN = 0;
        }

    }
}