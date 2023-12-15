using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DefinindoEventosPeloXaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DefinindoEventosPeloXaml.CalculadoraSimples();
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
