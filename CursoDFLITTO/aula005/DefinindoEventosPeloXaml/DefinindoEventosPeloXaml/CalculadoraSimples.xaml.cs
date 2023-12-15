using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DefinindoEventosPeloXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }
        private void Calculo(Object sender, EventArgs e)
        {
            Button b = (Button) sender;//sender é quem desencadeou a ação, nesse caso, vira o botão que for clicado.
            double val = 0;
            switch(b.Text){
                case "+": val = double.Parse(ValorUm.Text) + double.Parse(ValorDois.Text); break;
                case "-": val = double.Parse(ValorUm.Text) - double.Parse(ValorDois.Text); break;
                case "/": val = double.Parse(ValorUm.Text) / double.Parse(ValorDois.Text); break;
                case "*": val = double.Parse(ValorUm.Text) * double.Parse(ValorDois.Text); break;
            }
            Resposta.Text = val.ToString();
        }
    }
}