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
    public partial class Q3 : ContentPage
    {
        public Q3()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "OrihimeMo";
        }
        private async void Verificar(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Bleach")
                await Navigation.PushAsync(new Q4());
            else
                await Navigation.PushAsync(new GameOver());
        }
    }
}