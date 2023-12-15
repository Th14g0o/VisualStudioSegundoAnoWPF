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
    public partial class Ex2 : ContentPage
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void Executar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //!3 = 3 * 2 * 1
                int valor = int.Parse(Numero.Text);
                int n = valor;
                //defini n como 3
                Resultado.TextColor = Color.Green;
                if (n <= 0)
                {
                    Resultado.TextColor = Color.Red;
                    Resultado.Text = "DIGITE UM NUMERO MAIOR QUE 0";
                }
                else
                {
                    for (int i = n - 1; i > 0; i--)
                        valor = valor * i;
                    //multiplica n por 2, depois por 1 e acaba
                    Resultado.Text = $"{valor}";
                }
                


            }
            catch
            {
                Resultado.TextColor = Color.Red;
                Resultado.Text = "ERROR";
            }
        }
    }
}