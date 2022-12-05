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

namespace Tema02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Fabricante fabri;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cria_Click(object sender, RoutedEventArgs e)
        {
            fabri = new Fabricante(fabricanten.Text, fabricantes.Text);
            mudar.Header = fabri;
            inserib.IsEnabled = true;
            novo.IsEnabled = true;
            cria.IsEnabled = false;
        }

        private void inserib_Click(object sender, RoutedEventArgs e)
        {
            double preco;
            if (double.TryParse(veiculop.Text, out preco) == true)
            {
                Veiculo v = new Veiculo(veiculon.Text, veiculom.Text, preco);
                fabri.Inserir(v);
                lista.Items.Clear();
                listab.IsEnabled = true;
                maisb.IsEnabled = true;
            }
        }

        private void listab_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            foreach (Veiculo v in fabri.Listar())
                lista.Items.Add(v);
        }

        private void maisb_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add(fabri.MaiorPreco());
        }

        private void novo_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            cria.IsEnabled = true;
            inserib.IsEnabled = false;
            listab.IsEnabled = false;
            maisb.IsEnabled = false;
            novo.IsEnabled = false;
        }
    }
}
