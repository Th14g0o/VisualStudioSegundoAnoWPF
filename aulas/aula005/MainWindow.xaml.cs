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

namespace aula005
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Empresa x;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void coloca_nome_empresa_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow w2 = new MainWindow();
            //w2.Show();
            x = new Empresa(nome_empresa.Text);
            //MessageBox.Show(x.ToString());
        }

        private void info_cliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente(nome_cliente.Text, double.Parse(limite_cliente.Text));
            x.Inserir(c);
            //info_clientes.Items.Add(c);
            info_clientes.ItemsSource = null;
            info_clientes.ItemsSource = x.Listar();
           

        }
    }
}
