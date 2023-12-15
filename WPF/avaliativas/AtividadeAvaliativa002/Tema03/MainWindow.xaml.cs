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

namespace Tema03
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
        private Pais p;

        private void criarb_Click(object sender, RoutedEventArgs e)
        {
            double v;
            if (double.TryParse(areap.Text, out v))
            {
                p = new Pais(nomep.Text, v);
                criarb.IsEnabled = false;
                listarb.IsEnabled = true;
                pupulacaob.IsEnabled = true;
                listarb.IsEnabled = true;
                inserirb.IsEnabled = true;
                novob.IsEnabled = true;
                muda.Header = p;

            }
                

        }

        private void inserirb_Click(object sender, RoutedEventArgs e)
        {
            int popu;
            if (int.TryParse(populacaoe.Text, out popu))
            {
                lista.Items.Clear();
                Estado es = new Estado(nomee.Text, siglae.Text, popu);
                p.Inserir(es);
            }
        }

        private void listarb_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            foreach (Estado es in p.Listar())
                lista.Items.Add(es);
        }

        private void pupulacaob_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add(p.Populacao().ToString()+" Habitantes");
        }

        private void novob_Click(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            criarb.IsEnabled = true;
            listarb.IsEnabled = false;
            pupulacaob.IsEnabled = false;
            listarb.IsEnabled = false;
            inserirb.IsEnabled = false;
            novob.IsEnabled = false;
        }
    }
}
