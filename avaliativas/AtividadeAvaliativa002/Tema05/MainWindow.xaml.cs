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

namespace Tema05
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
        private Turma tur = new Turma("", "");
        private void criar_Click(object sender, RoutedEventArgs e)
        {
            if(curso.Text != "" && codigo.Text != "")
            {
                tur = new Turma(curso.Text, codigo.Text);
                lista.Header = tur;
                inserir.IsEnabled = true;
                criar.IsEnabled = false;
            }
            
        }

        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            int i;
            if (int.TryParse(ira.Text, out i) && email.Text.ToString().IndexOf('@') != -1 && nome.Text != "" && matricula.Text != "")
            {
                exibir.Items.Clear();
                Aluno a = new Aluno(email.Text, nome.Text, matricula.Text, i);
                tur.Inserir(a);
                listar.IsEnabled = true;
                maior_ira.IsEnabled = true;
                reiniciar.IsEnabled = true;
            }
        }

        private void reiniciar_Click(object sender, RoutedEventArgs e)
        {
            listar.IsEnabled = false;
            maior_ira.IsEnabled = false;
            inserir.IsEnabled = false;
            criar.IsEnabled = true;
            reiniciar.IsEnabled = false;
            exibir.Items.Clear();
            nome.Text = "";
            matricula.Text = "";
            ira.Text = "";
            email.Text = "";
            codigo.Text = "";
            curso.Text = "";
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            exibir.Items.Clear();
            foreach (Aluno a in tur.Listar())
                exibir.Items.Add(a);
        }

        private void maior_ira_Click(object sender, RoutedEventArgs e)
        {
            exibir.Items.Clear();
            exibir.Items.Add(tur.MaiorIra());
        }
    }
}
