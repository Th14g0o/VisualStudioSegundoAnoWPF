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
    public partial class Cores : ContentPage
    {
        public Cores()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                Preto.Source = "pret";
                Branco.Source = "bran";
                Azul.Source = "azul";
                Vermelho.Source = "verm";
                Verde.Source = "verd";
                Laranja.Source = "lara";
            }
        }
    }
}