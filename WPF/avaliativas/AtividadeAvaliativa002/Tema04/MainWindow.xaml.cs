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

namespace Tema04
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
        Genero gen;
        private void criar_Click(object sender, RoutedEventArgs e)
        {
            gen = new Genero(genero.Text);
            if (gen.GetNome() != "")
            {
                lista.Header = gen;
                inserir.IsEnabled = true;
                reiniciar.IsEnabled = true;
                criar.IsEnabled = false;
            }
            
        }
        private bool novo = true;
        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            exibir.Items.Clear();
            double v;         
            Livro l;
            if (double.TryParse(preco.Text, out v) == true && novo == true)
            {
                l = new Livro(nome.Text, autor.Text, v);
                if(l.GetPreco() >= 0 && l.GetNome() != "-1" && l.GetAutor() != "-1")
                {
                    nome.Text = "";
                    autor.Text = "";
                    preco.Text = "";
                    gen.Inserir(l);
                    listar.IsEnabled = true;
                    menor.IsEnabled = true;
                }

            }
         
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            exibir.Items.Clear();
            foreach (Livro l in gen.Listar())
                exibir.Items.Add(l);
        }

        private void menor_Click(object sender, RoutedEventArgs e)
        {
            exibir.Items.Clear();
            exibir.Items.Add(gen.MenorPreco());
        }

        private void reiniciar_Click(object sender, RoutedEventArgs e)
        {
            listar.IsEnabled = false;
            menor.IsEnabled = false;
            inserir.IsEnabled = false;
            reiniciar.IsEnabled = false;
            criar.IsEnabled = true;
            genero.Text = "";
            nome.Text = "";
            autor.Text = "";
            preco.Text = "";
        }
    }
}
