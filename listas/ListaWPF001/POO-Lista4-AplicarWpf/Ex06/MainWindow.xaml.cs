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

namespace Ex06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Bingo jogo = new Bingo();

        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void iniciar_jogo_Click(object sender, RoutedEventArgs e)
        {
            jogo.Iniciar(int.Parse(quant_bolas.Text));
            sorteando.IsEnabled = true;
            iniciar_jogo.IsEnabled = false;
            slider.IsEnabled = false;
            quant_bolas.IsEnabled = false;
        }

        private void sorteando_Click(object sender, RoutedEventArgs e)
        {
            int bolinha = jogo.Proximo();
            if (bolinha == -1)
            {
                sorteando.IsEnabled = false;
                iniciar_jogo.IsEnabled = true;
                slider.IsEnabled = true;
                quant_bolas.IsEnabled = true;
                ultima_bola.Text = "Acabou";

            }
            else
            {
                
                ultima_bola.Text = bolinha.ToString();

                int[] valores = jogo.Sorteados();
                int tam = valores.Length;
                string bolas_usadas = "";
                for (int indice = 0; indice < tam; indice++)
                {
                    if (indice > 0) bolas_usadas += " - ";
                    bolas_usadas += valores[indice].ToString();
                }
                usadas.Text = bolas_usadas;
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            quant_bolas.Text = slider.Value.ToString();
        }
    }
}
