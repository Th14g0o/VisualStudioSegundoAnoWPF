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
        private Aluno a;
        private bool novo_a = true, nova_tur = true;
        private void criar_Click(object sender, RoutedEventArgs e)
        {
            if (nova_tur == true)
            {
                tur = new Turma(curso.Text, codigo.Text);
                nova_tur = false;
            }
            else
            {
                tur.SetCurso(curso.Text);
                tur.SetCodigo(codigo.Text);
            }

            if (tur.GetCurso() == "-1")
                curso.Text = "INVALIDO";
            if (tur.GetCodigo() == "-1")
                codigo.Text = "INVALIDO";

            if (tur.GetCurso() != "-1" && tur.GetCodigo() != "-1")
            {
                nova_tur = true;
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
            bool tf = int.TryParse(ira.Text, out i);
            if (tf == false)
                i = -1;

            if (novo_a == true)
            {
                a = new Aluno(email.Text, nome.Text, matricula.Text, i);
                novo_a = false;
            }
            else
            {
                a.SetEmail(email.Text);
                a.SetIRA(i);
                a.SetNome(nome.Text);
                a.SetMatricula(matricula.Text);
            }

            if (a.GetEmail() == "-1")
                email.Text = "INVALIDO";
            if (a.GetNome() == "-1")
                nome.Text = "INVALIDO";
            if (a.GetMatricula() == "-1")
                matricula.Text = "INVALIDO";
            if (a.GetIRA() == -1)
                ira.Text = "INVALIDO";

            if (a.GetEmail() != "-1" && a.GetNome() != "-1" && a.GetMatricula() != "-1" && a.GetIRA() != -1)
            {
                novo_a = true;
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
