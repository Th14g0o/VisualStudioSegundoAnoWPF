using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavegationHierarquiaEntrePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private async void Troca2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            //desempilha a pagina
        }
    }
}