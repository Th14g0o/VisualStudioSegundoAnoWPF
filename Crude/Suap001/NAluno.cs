using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Suap001
{
    static class NAluno
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public static void Inserir(Aluno a)
        {
            Abrir();
            alunos.Add(a);
            Salvar();
        }

        public static List<Aluno> Listar()
        {
            Abrir();
            return alunos;
        }
        public static void Exluir(Aluno a)
        {
            Abrir();
            alunos.Remove(Checar(a.Id));
            Salvar();
        }
        public static void Atualizar(Aluno a)
        {
            Abrir();
            Aluno obj = Checar(a.Id);
            obj.Matricula = a.Matricula;
            obj.IdTurma = a.IdTurma;
            obj.Email = a.Email;
            obj.Nome = a.Nome;
            Salvar();
        }
        public static Aluno Checar(int a)
        {
            foreach (Aluno x in alunos)
                if (a == x.Id) return x;
            return null;

        }

        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
            StreamWriter f = new StreamWriter("./RegistroAluno.xml", false);
            xml.Serialize(f, alunos);
            f.Close();
        }

        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
                f = new StreamReader("./RegistroAluno.xml");
                alunos = (List<Aluno>)xml.Deserialize(f);
            }
            catch
            {
                alunos = new List<Aluno>();
            }  
            if ( f!= null) f.Close();

        }
    }
}
