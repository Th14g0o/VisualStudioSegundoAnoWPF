using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Decifra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Q5 : ContentPage
    {
        public Q5()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "GeovanyMo";
        }
        private async void Verificar(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Pokemon")
                await Navigation.PushAsync(new Q6());
            else
                await Navigation.PushAsync(new GameOver());
        }
    }
}