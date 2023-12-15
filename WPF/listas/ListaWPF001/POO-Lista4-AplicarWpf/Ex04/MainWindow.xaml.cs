using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            EquacaoIIGrau info = new EquacaoIIGrau();
            double x1, x2;
            info.SetABC(double.Parse(coeficiente_a.Text), double.Parse(coeficiente_b.Text), double.Parse(coeficiente_c.Text));
            if(info.RaizesReais() == true)
            {
                delt.Text = info.CalcDelta().ToString();
                info.X1(out x1);
                info.X2(out x2);
                x_1.Text = x1.ToString();
                x_2.Text = x2.ToString();
            }
            else
            {
                delt.Text = info.CalcDelta().ToString();
                x_1.Text = "Não é real";
                x_2.Text = "Não é real";
            }



        }
    }
}
