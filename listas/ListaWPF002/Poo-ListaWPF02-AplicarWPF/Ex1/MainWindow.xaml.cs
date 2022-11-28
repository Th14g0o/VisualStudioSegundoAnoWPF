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

namespace Ex1
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

        private void start_Click(object sender, RoutedEventArgs e)
        {
            Intervalo info = new Intervalo();
            int x = 0;
            int y = 0;
            bool n1 = int.TryParse(ini.Text, out x);
            bool n2 = int.TryParse(fim.Text, out y);
            if (n1 == true && n2 == true && x <= y)
            {
                info.SetInicio(x);
                info.SetFim(y);

                todos.Items.Clear();
                foreach (int a in info.Numeros())
                {
                    todos.Items.Add(a);
                }
            }

        }
    }
}
