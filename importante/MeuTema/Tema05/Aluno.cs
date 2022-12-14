using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema05
{
    internal class Aluno
    {
        private string email, nome, matricula;
        private int ira;

        public Aluno(string email, string nome, string matricula, int ira)
        {
            if (email.IndexOf('@') != -1) this.email = email;
            else this.email = "-1";

            if (nome != "" && nome.ToUpper() != "INVALIDO" ) this.nome = nome;
            else this.nome = "-1";

            if (matricula != "" && matricula.ToUpper() != "INVALIDO") this.matricula = matricula;
            else this.matricula = "-1";

            if (ira >= 0) this.ira = ira;
            else this.ira = -1;
        }

        public void SetEmail(string email)
        {
            if (email.IndexOf('@') != -1) this.email = email;
            else this.email = "-1";
        }
        public void SetNome(string nome)
        {
            if (nome != "" && nome.ToUpper() != "INVALIDO") this.nome = nome;
            else this.nome = "-1";
        }
        public void SetMatricula(string matricula)
        {
            if (matricula != "" && matricula.ToUpper() != "INVALIDO") this.matricula = matricula;
            else this.matricula = "-1";
        }
        public void SetIRA(int ira)
        {
            if (ira >= 0) this.ira = ira;
            else this.ira = -1;

        }
        public int GetIRA()
        {
            return ira;
        }
        public string GetMatricula()
        {
            return matricula;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetEmail()
        {
            return email;
        }

        public override string ToString()
        {
            return $"Aluno: {nome} | Matricula: {matricula} | IRA: {ira}% | Email: {email}";
        }
    }
}
