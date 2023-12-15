using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AreaDoTriangulo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Ex2();
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
