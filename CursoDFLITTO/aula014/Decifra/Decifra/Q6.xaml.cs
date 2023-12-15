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
    public partial class Q6 : ContentPage
    {
        public Q6()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "HinataMo";
        }
        private async void Verificar(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Naruto The Last")
                await Navigation.PushAsync(new Q7());
            else
                await Navigation.PushAsync(new GameOver());
        }
    }
}