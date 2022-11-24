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

namespace Ex05
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

        private void calcular_button_Click(object sender, RoutedEventArgs e)
        {
            
            Numeros intervalo = new Numeros(int.Parse(inicio_intervalo.Text), int.Parse(fim_intervalo.Text));

            for (int indice = 0; indice < intervalo.Calcular(impars.IsChecked.Value, pars.IsChecked.Value).Length; indice++)
            {
                IntervaloNumerico.Items.Add(intervalo.Calcular(impars.IsChecked.Value, pars.IsChecked.Value)[indice]);
            }
        }

        private void IntervaloNumerico_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IntervaloNumerico.SelectedItem != null) IntervaloNumerico.Items.Remove(IntervaloNumerico.SelectedItem);
        }
    }
}
