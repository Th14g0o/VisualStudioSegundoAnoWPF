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

namespace Ex02
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

        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            registrar infos = new registrar(nome.Text, fone.Text, emai.Text);
            listadecontatos.Items.Add(infos);
        }

        private void exclui_Click(object sender, RoutedEventArgs e)
        {
            if (listadecontatos.SelectedItem != null) listadecontatos.Items.Remove(listadecontatos.SelectedItem);
        }
    }
}
