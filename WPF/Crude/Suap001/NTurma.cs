using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suap001
{
    static class NTurma
    {
        private static List<Turma> turmas = new List<Turma>();

        public static void Inserir(Turma t)
        {
            Abrir();
            turmas.Add(t);
            Salvar();
        }

        public static List<Turma> Listar()
        {
            Abrir();
            return turmas;
        }

        public static Turma IdT(int id)
        {
            foreach (Turma t in turmas)
                if (t.Id == id) return t;
            return null;
        }

        public static void Atualizar(Turma t)
        {
            Abrir();
            Turma obj = IdT(t.Id);
            obj.Curso = t.Curso;
            obj.Descricao = t.Descricao;
            obj.AnoLetivo = t.AnoLetivo;
            Salvar();

        }

        public static void Excluir(Turma t)
        {
            Abrir();
            turmas.Remove(IdT(t.Id));
            Salvar();
        }

        public static void Abrir()
        {
            StreamReader f = null;
            try // caso der para efutuar os comandos a seguir
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
                f = new StreamReader("./TurmasRegistro.xml");
                turmas = (List<Turma>)xml.Deserialize(f);
            }
            catch// caso não der para efutuar os comandos acima
            {
                turmas = new List<Turma>();
            }
            if (f != null) f.Close();

        }

        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
            StreamWriter f = new StreamWriter("./TurmasRegistro.xml", false); 
            xml.Serialize(f, turmas); 
            f.Close();
        }
    }
}
