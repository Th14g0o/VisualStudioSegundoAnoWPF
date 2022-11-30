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

namespace Tema01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Time t;
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void criar_Click(object sender, RoutedEventArgs e)
        {
            t = new Time(nt.Text, et.Text);
            atleta.Header = t;
            inserir.IsEnabled = true;
            artilheiro.IsEnabled = true;
            listar.IsEnabled = true;
            criar.IsEnabled = false;
        }

        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            Jogador j = new Jogador(nj.Text, cj.Text, int.Parse(gj.Text));
            t.Inserir(j);
            if (t.Listar().Length == 22)
                inserir.IsEnabled = false;
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            atletas.Items.Clear();
            foreach (Jogador j in t.Listar())
                atletas.Items.Add(j);
        }

        private void artilheiro_Click(object sender, RoutedEventArgs e)
        {
            atletas.Items.Clear();
            foreach (Jogador j in t.Artilheiro())
                atletas.Items.Add(j);
        }
    }
}
