using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tabuada
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Gerar_Clicked(object sender, EventArgs e)
        {
            int n;
            List<string> tabuada = new List<string>(); 
            try
            {
                n = int.Parse(Num.Text);
                for (int i = 0; i <= 10; i++)
                {
                    tabuada.Add($"{n} X {i:00} = {i * n}");
                }
                Tabuada.ItemsSource = tabuada;
            }
            catch
            {
                tabuada.Add("Error");
                Tabuada.ItemsSource = tabuada;
            }
        }
    }
}
