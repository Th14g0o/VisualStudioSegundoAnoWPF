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
    public partial class Q9 : ContentPage
    {
        public Q9()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "SanosukeMo";
        }
        private async void Verificar(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Samurai X")
                await Navigation.PushAsync(new Q10());
            else
                await Navigation.PushAsync(new GameOver());
        }
    }
}