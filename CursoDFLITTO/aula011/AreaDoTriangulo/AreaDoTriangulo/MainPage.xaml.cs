using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AreaDoTriangulo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            try
            {
                Resultado.Text = $"Área = {double.Parse(baseT.Text) * double.Parse(alturaT.Text) / 2.0:0.00}";
                Resultado.TextColor = Color.Green;
            }
            catch
            {
                Resultado.Text = "Error";
                Resultado.TextColor = Color.Red;
            }
        }
    }
}
