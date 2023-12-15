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
    public partial class Numeros : ContentPage
    {
        public Numeros()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                Zero.Source = "num00.png";
                Um.Source = "num01.png";
                Dois.Source = "num02.png";
                Tres.Source = "num03.png";
                Quatro.Source = "num04.png";
                Cinco.Source = "num05.png";
            }
        }
    }
}