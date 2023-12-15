using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UmaPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new UmaPage.MainPage();
            //MainPage = new UmaPage.ParOuImpar();
            MainPage = new ParOuImpar();
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
