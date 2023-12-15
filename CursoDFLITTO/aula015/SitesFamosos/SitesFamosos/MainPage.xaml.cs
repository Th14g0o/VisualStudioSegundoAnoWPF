using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SitesFamosos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
                site1.Source = "site1";
        }
        private void FoiClicado1(Object sender, EventArgs args)
        {
            Device.OpenUri(new Uri("https://portal.ifrn.edu.br/"));
        }
        //private void FoiClicado2(Object sender, EventArgs args)
        //{
        //    Device.OpenUri(new Uri("https://portal.ifrn.edu.br/"));
        //}
        //private void FoiClicado3(Object sender, EventArgs args)
        //{
        //    Device.OpenUri(new Uri("https://portal.ifrn.edu.br/"));
        //}

    }
}
