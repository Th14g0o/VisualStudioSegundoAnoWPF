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
    public partial class Ganhou : ContentPage
    {
        public Ganhou()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                Imagem.Source = "GanhouMo";
        }
        private async void Reiniciar(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}