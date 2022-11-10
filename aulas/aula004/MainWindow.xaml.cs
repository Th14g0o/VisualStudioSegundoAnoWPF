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

namespace aula004
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

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bolas_ini.Text = slider.Value.ToString();
        }

        Bingo jogo = new Bingo();

        private void inicio_Click(object sender, RoutedEventArgs e)
        {
            //Bingo jogo = new Bingo();
            jogo.Iniciar(int.Parse(bolas_ini.Text));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Bingo jogo = new Bingo();
            //jogo.Iniciar(int.Parse(bolas_ini.Text));
            if (jogo.Proximo() == -1) sorteando.IsEnabled = false;
            ultima_bola.Text = (jogo.Proximo()).ToString();
            int tam = jogo.Sorteados().Length;
            string bolas_usadas = "";
            for (int indice = 0; indice < tam; indice++)
            {
                if (indice > 0) bolas_usadas += " - ";
                bolas_usadas += ((jogo.Sorteados())[indice]).ToString();
            }
            usadas.Text = bolas_usadas;
        }
    }
}
