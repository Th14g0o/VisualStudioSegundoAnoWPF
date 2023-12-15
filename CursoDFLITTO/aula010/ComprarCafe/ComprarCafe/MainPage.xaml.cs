using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComprarCafe
{
    public partial class MainPage : ContentPage
    {
        public int quant { get; set; }
        public double total { get; set; }
        public double valor { get; set; }
        public MainPage()
        {
            InitializeComponent();
            quant = 0;
            total = 0;
            valor = 3.52;
        }
    
        public void Recalculando(Object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "+")
            {
                quant++;
            }
            else
            {
                if (quant > 0)
                    quant--;    
            }
            total = quant * valor;
            TotalCoffe.Text = $"Total: R$ {total:0.00}";
            QuantCoffe.Text = "Quantidade: " + quant.ToString();
        }
    }
}
