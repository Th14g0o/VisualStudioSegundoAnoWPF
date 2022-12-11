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
        private Turma tur;
        private void criar_Click(object sender, RoutedEventArgs e)
        {
            tur = new Turma("", "");
            tur.SetCurso(curso.Text);
            tur.SetCodigo(codigo.Text);
            if (tur.GetCurso() != "" && tur.GetCodigo() != "")
            {
                lista.Header = tur;
                inserir.IsEnabled = true;
                criar.IsEnabled = false;
                reiniciar.IsEnabled = true;
                codigo.IsEnabled = false;
                curso.IsEnabled = false;
            }   
        }
        private void inserir_Click(object sender, RoutedEventArgs e)
        {
            
            int i;
            Aluno a = new Aluno("-1", "-1", "-1", -1);
            a.SetEmail(email.Text);
            if (int.TryParse(ira.Text, out i) == true)
                a.SetIRA(i);
            a.SetNome(nome.Text);
            a.SetMatricula(matricula.Text);       

            if (a.Verifica() == true)
            {
                exibir.Items.Clear();
                tur.Inserir(a);
                nome.Text = "";
                matricula.Text = "";
                ira.Text = "";
                email.Text = "";
                listar.IsEnabled = true;
                maior_ira.IsEnabled = true;
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
            codigo.IsEnabled = true;
            curso.IsEnabled = true;
            lista.Header = "";
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
