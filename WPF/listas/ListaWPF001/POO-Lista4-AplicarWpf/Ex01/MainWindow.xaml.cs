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

namespace Ex01
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

        private void calcular_Click(object sender, RoutedEventArgs e)
        {
            Abastecimento infos = new Abastecimento();
            infos.SetKmRodados(double.Parse(km.Text));
            infos.SetValorLitro(double.Parse(li.Text));
            infos.SetValorPago(double.Parse(pa.Text));
            rs_km.Text = Math.Round(infos.CalcReaisKm(), 2).ToString("N2");
            km_li.Text = Math.Round(infos.CalcKmLitro(),2).ToString("N2");
        }
    }
}
