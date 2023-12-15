using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnglishParaKids
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Familia : ContentPage
    {
        public Familia()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                Vozinho.Source = "vozinho.png";
                Vozinha.Source = "vozinha.png";
                Pai.Source = "pai.png";
                Mae.Source = "mae.png";
                Filho.Source = "filho.png";
                Filha.Source = "filha.png";
            }
        }
    }
}