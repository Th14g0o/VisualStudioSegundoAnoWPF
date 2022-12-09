using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema05
{
    internal class Aluno
    {
        private string email = "", nome = "", matricula = "";
        private int ira;
        public Aluno(string email, string nome, string matricula, int ira)
        {
            if (email.IndexOf('@') != -1) this.email = email;
            if (nome != "")this.nome = nome;
            if(matricula != "") this.matricula = matricula;
            if (ira >= 0) this.ira = ira;
        }
        public override string ToString()
        {
            return $"Aluno: {nome} - Matricula: {matricula} - IRA: {ira} - Email: {email}";
        }
        public int GetIRA()
        {
            return ira;
        }

    }
}
