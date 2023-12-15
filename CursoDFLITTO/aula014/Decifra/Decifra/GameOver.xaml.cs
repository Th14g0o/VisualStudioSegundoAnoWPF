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
    public partial class GameOver : ContentPage
    {
        public GameOver()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "PerdeuMo";
        }

        private async void Reiniciar(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}