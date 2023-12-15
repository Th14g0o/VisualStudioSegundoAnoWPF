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
    public partial class Decifrando : ContentPage
    {
        public Decifrando()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "DestaqueInicialMo";

        }

        private async void Inicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Q1());
            
        }
    }
}