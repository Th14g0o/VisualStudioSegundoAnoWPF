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

namespace Aula002
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
            Tri infos = new Tri();
            infos.SetAltu(double.Parse(altun.Text));
            infos.SetBase(double.Parse(basen.Text));
            area.Text = infos.CalcArea().ToString();
            diag.Text = infos.CalcDiag().ToString();

        }
    }
}
