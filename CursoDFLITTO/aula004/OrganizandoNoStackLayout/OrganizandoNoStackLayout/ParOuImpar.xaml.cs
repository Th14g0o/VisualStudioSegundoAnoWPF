using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrganizandoNoStackLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentPage
    {
        public ParOuImpar()
        {
            InitializeComponent();
            ExecutarVerificar.Clicked += ExecutarVerificar_Clicked;
        }

        private void ExecutarVerificar_Clicked(object sender, EventArgs e)
        {
            if (int.Parse(Valor.Text) % 2 == 0)
                Resposta.Text = "O numero " + Valor.Text + " é par";
            else
                Resposta.Text = "O numero " + Valor.Text + " é impar";
        }
    }
}