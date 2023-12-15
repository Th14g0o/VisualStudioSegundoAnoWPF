using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EnglishParaKids
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                Destaque.Source = "destaque";
                Link.Source = "link";
            }
            
        }
        private async void Direcionar(Object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "Cores")
                await Navigation.PushAsync(new Cores());
            else if (b.Text == "Numeros")
                await Navigation.PushAsync(new Numeros());
            else
                await Navigation.PushAsync(new Familia());
        }
        private  void Sair(Object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill(); 
            //fecha aplicativo
        }
        private void VisitarLink(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://portal.ifrn.edu.br"));
        }
    }
}
