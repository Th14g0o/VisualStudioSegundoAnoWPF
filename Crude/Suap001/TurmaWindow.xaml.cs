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
    /// Lógica interna para TurmaWindow.xaml
    /// </summary>
    public partial class TurmaWindow : Window
    {
        public TurmaWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma { Id = int.Parse(txtId.Text), Curso = txtCurso.Text, AnoLetivo = int.Parse(txtAno.Text), Descricao = txtTurma.Text };
            NTurma.Inserir(t);
            ListarClick(sender, e);// chama a ação do butão
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listTurmas.ItemsSource = null;
            listTurmas.ItemsSource = NTurma.Listar();
            //listTurmas.Items.Clear();
            //foreach (Turma t in NTurma.Listar())
            //listTurmas.Items.Add(t);
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma { Id = int.Parse(txtId.Text), Curso = txtCurso.Text, AnoLetivo = int.Parse(txtAno.Text), Descricao = txtTurma.Text };
            NTurma.Atualizar(t);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            //sender e o proprio butão e "e" serria os dados que vem
            if (listTurmas.SelectedItem != null)
            {
                NTurma.Excluir((Turma)listTurmas.SelectedItem);//Nome_Classe entre parentes antes de algo tenta converter
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("Selecione um item para deletar!");
            }

        }
    }
}
