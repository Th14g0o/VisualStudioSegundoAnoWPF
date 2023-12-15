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
using System.Windows.Shapes;

namespace Suap001
{
    /// <summary>
    /// Lógica interna para AlunoWindow.xaml
    /// </summary>
    public partial class AlunoWindow : Window
    {
        public AlunoWindow()
        {
            InitializeComponent();
        }

        private void inseri_aluno_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Aluno a = new Aluno { Email = e_aluno.Text, Id = int.Parse(id_aluno.Text), IdTurma = int.Parse(idt_aluno.Text), Matricula = m_aluno.Text, Nome = n_aluno.Text };
                NAluno.Inserir(a);
                lista_aluno_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Coloque numeros no ID e/ou no ID da turma");
            }
        }

        private void lista_aluno_Click(object sender, RoutedEventArgs e)
        {
            exibi_aluno.ItemsSource = null;
            exibi_aluno.ItemsSource = NAluno.Listar();
        }

        private void atualiza_aluno_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Aluno a = new Aluno { Email = e_aluno.Text, Id = int.Parse(id_aluno.Text), IdTurma = int.Parse(idt_aluno.Text), Matricula = m_aluno.Text, Nome = n_aluno.Text };
                NAluno.Atualizar(a);
                lista_aluno_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Coloque numeros no ID e/ou no ID da turma");
            }
            
        }

        private void apaga_aluno_Click(object sender, RoutedEventArgs e)
        {
            if (exibi_aluno.SelectedItem != null)
            {
                NAluno.Exluir((Aluno)exibi_aluno.SelectedItem);
                lista_aluno_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Selecione um item!");
            }
        }

        private void exibi_aluno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Aluno a = (Aluno)exibi_aluno.SelectedItem;
            e_aluno.Text = a.Email;
            id_aluno.Text = a.Id.ToString();
            idt_aluno.Text = a.IdTurma.ToString();
            m_aluno.Text = a.Matricula;
            n_aluno.Text = a.Nome;
        }
    }
}
