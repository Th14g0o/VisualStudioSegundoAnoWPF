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
    /// Lógica interna para MatriculaWindow.xaml
    /// </summary>
    public partial class MatriculaWindow : Window
    {
        public MatriculaWindow()
        {
            InitializeComponent();
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            lista_alunos.ItemsSource = null;
            lista_alunos.ItemsSource = NAluno.Listar();
            lista_turmas.ItemsSource = null;
            lista_turmas.ItemsSource= NTurma.Listar();
        }

        private void matricular_Click(object sender, RoutedEventArgs e)
        {
            if (lista_alunos.SelectedItem != null && lista_turmas.SelectedItems != null)
            {
                Aluno a = (Aluno)lista_alunos.SelectedItem;
                Turma t = (Turma)lista_turmas.SelectedItem;
                NAluno.Matricular(a, t);
                listar_Click(sender, e);
            }
            else
                MessageBox.Show("Selecione uma turma e/ou um aluno!");
        }
    }
}
