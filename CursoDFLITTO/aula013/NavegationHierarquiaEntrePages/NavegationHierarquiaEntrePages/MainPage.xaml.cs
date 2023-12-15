using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavegationHierarquiaEntrePages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Troca1_Clicked(object sender, EventArgs e)
        {
            //o async é necessario para o await (comando que empilha uma pagina)
            await Navigation.PushAsync(new MainPage2());
        }
    }
}
