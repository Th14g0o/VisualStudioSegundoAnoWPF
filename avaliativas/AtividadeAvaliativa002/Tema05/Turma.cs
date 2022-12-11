using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema05
{
    internal class Turma
    {
        private string curso = "", codigo = "";
        private Aluno[] alunos = new Aluno[10];
        private int indice = 0;

        public Turma(string curso, string codigo)
        {
            this.curso = curso;
            this.codigo = codigo;
        }

        public void SetCurso(string curso)
        {
            if (curso != "") this.curso = curso;
        }
        public void SetCodigo(string codigo)
        {
            if (codigo != "") this.codigo = codigo;
        }
        public string GetCurso()
        {
            return curso;
        }
        public string GetCodigo()
        {
            return codigo;
        }


        public override string ToString()
        {
            return $"{curso}({codigo})";
        }


        public void Inserir(Aluno a)
        {
            if (indice == alunos.Length)
                Array.Resize(ref alunos, alunos.Length + 6);
            alunos[indice] = a;
            indice++;
        }


        public Aluno[] Listar()
        {
            Aluno[] listando = new Aluno[indice];
            Array.Copy(alunos, listando, indice);
            return listando;
        }


        public Aluno MaiorIra()
        {
            int[] organi = new int[indice];
            for (int i = 0; i < indice; i++)
                organi[i] = Listar()[i].GetIRA();
            Array.Sort(organi);
            Array.Reverse(organi);

            Aluno a = Listar()[0];
            for (int i = 0; i < indice; i++)
                if (organi[0] == Listar()[i].GetIRA())
                    a = Listar()[i];
            return a;
        }
    }
}
