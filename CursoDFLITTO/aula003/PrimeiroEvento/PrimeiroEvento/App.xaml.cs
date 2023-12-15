using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeiroEvento
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PrimeiroEvento.ParOuImpar();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
