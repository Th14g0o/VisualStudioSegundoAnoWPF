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

namespace Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Jogador pessoas = new Jogador();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inserindo_Click(object sender, RoutedEventArgs e)
        {
            Jogador pessoa = new Jogador();
            pessoa.SetNome(nome.Text);
            pessoa.SetGols(int.Parse(gol.Text));
            pessoas.Inserir(pessoa);
        }

        private void mostrar_Click(object sender, RoutedEventArgs e)
        {
            todos.Items.Clear();
            foreach(Jogador j in pessoas.Listar())
            {
                todos.Items.Add($"{j.GetNome()} - {j.GetGols()} gols");
            }
        }
    }
}
