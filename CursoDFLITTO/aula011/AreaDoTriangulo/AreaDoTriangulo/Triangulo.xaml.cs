using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AreaDoTriangulo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Triangulo : ContentPage
    {
        public bool b { get; set; }
        public bool Op { get; set; }
        public Triangulo()
        {
            InitializeComponent();
            b = true;
            Op = true;
            Fator.Num = 0;
            Trian.Altu = 0;
            Trian.Base = 0;
            Permanece.TextColor = Color.DeepSkyBlue;

        }

        private void Iniciar(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Op == true)
            {
                if (b.Text == "Base:")
                {
                    this.b = true;
                    Permanece.TextColor = Color.DeepSkyBlue;
                    Excluido.TextColor = Color.White;
                }

                else
                {
                    this.b = false;
                    Permanece.TextColor = Color.White;
                    Excluido.TextColor = Color.DeepSkyBlue;
                }
                    
            }
            
        }
        private void Atribuir(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            double x;

            if(Op == true)
            {
                if (ba.Text == "0" && this.b == true)
                {
                    ba.Text = b.Text;
                    if (double.TryParse(ba.Text, out x))
                        Trian.Base = x;
                }
                else if (ba.Text != "0" && this.b == true)
                {

                    ba.Text += b.Text;
                    if (double.TryParse(ba.Text, out x))
                        Trian.Base = double.Parse(ba.Text);
                }
                if (al.Text == "0" && this.b == false)
                {
                    al.Text = b.Text;
                    if (double.TryParse(al.Text, out x))
                        Trian.Altu = x;

                }
                else if (al.Text != "0" && this.b == false)
                {

                    al.Text += b.Text;
                    if (double.TryParse(al.Text, out x))
                        Trian.Altu = double.Parse(al.Text);
                }
            }
            else
            {
                if (ba.Text == "0" && this.b == true)
                {
                    ba.Text = b.Text;
                    if (double.TryParse(ba.Text, out x))
                        Fator.Num = x;
                }
                else if (ba.Text != "0" && this.b == true)
                {

                    ba.Text += b.Text;
                    if (double.TryParse(ba.Text, out x))
                        Fator.Num = double.Parse(ba.Text);
                }
            }
            
        }
        private void Limpar(object sender, EventArgs e)
        {
            Trian.Base = 0;
            Trian.Altu = 0;
            Fator.Num = 0;
            b = true;
            ba.Text = "0";
            al.Text = "0";
            Resultado.Text = "0";
            if (Op == true)
            {
                Permanece.TextColor = Color.DeepSkyBlue;
                Excluido.TextColor = Color.White;
            }
            else
            {
                Permanece.TextColor = Color.White;
                Excluido.TextColor = Color.White;
            }
        }

        private void Calcular(object sender, EventArgs e)
        {
            if (Permanece.Text == "Base:")
            {
                Resultado.Text = $"{Trian.Area():0.00}";
                ba.Text = "0";
                al.Text = "0";  
                Trian.Altu = 0;
                Trian.Base = 0;
            }
            else
            {
                Resultado.Text = $"{Fator.Fatorial()}";
                ba.Text = "0";
                Fator.Num = 0;
            }
            
        }

        private void Opera(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Resultado.Text = "0";
            if (b.Text == "Tri")
            {
                this.b = true;
                Excluido.IsVisible = false;
                Permanece.Text = "Numero:";
                al.IsVisible = false;
                b.Text = "!";
                Op = false;
                Fator.Num = 0;
                ba.Text = Fator.Num.ToString();
                Permanece.TextColor = Color.White;
            }
            else
            {
                this.b = true;
                Permanece.TextColor = Color.DeepSkyBlue;
                Excluido.TextColor = Color.White;
                Excluido.IsVisible = true;
                Permanece.Text = "Base:";
                al.IsVisible = true;
                b.Text = "Tri";
                Op = true;
                Trian.Altu = 0;
                Trian.Base = 0;
                ba.Text = Trian.Base.ToString();
                al.Text = Trian.Altu.ToString();
            }
        }
    }
}