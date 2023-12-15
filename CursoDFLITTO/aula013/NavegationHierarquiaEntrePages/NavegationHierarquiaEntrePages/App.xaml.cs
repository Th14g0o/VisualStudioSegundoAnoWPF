using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavegationHierarquiaEntrePages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            //Aqui "marcamos"(indicamos que vai ter naveçã de paginas) a MainPage como a primeira pagina da pilha. 
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
