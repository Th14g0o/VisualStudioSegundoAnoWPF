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
    public partial class Q2 : ContentPage
    {
        public Q2()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "KanekiMo";
        }
        private async void Verificar(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Tokyo Ghoul")
                await Navigation.PushAsync(new Q3());
            else
                await Navigation.PushAsync(new GameOver());
        }
    }
}