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
    public partial class Q1 : ContentPage
    {
        public Q1()
        {
            InitializeComponent();
            DisplayAlert("Objetivo:", "Tente acertar qual o anime com apenas duas dicas", "COMEÇAR DE VERDADE");
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "GokuMo";
        }

        private async void Verificar(object sender, EventArgs e)
        {
            if (RespPerg.Text != null && RespPerg.Text.ToLower() == "dragon ball")
                await Navigation.PushAsync(new Q2());
            else
                await Navigation.PushAsync(new GameOver());
        }
    }
}