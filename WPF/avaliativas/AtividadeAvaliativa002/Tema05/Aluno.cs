using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema05
{
    internal class Aluno
    {
        private string email = "-1", nome = "-1", matricula = "-1";
        private int ira = -1;

        public Aluno(string email, string nome, string matricula, int ira)
        {
            this.email = email;
            this.nome = nome;
            this.matricula = matricula;
            this.ira = ira;
        }

        public void SetEmail(string email)
        {
            if (email.IndexOf('@') != -1) this.email = email;
        }
        public void SetNome(string nome)
        {
            if (nome != "") this.nome = nome;
        }
        public void SetMatricula(string matricula)
        {
            if (matricula != "") this.matricula = matricula;
        }
        public void SetIRA(int ira)
        {
            if (ira >= 0) this.ira = ira;
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


        public bool Verifica()
        {
            if (email != "-1" && nome != "-1" && matricula != "-1" && ira >= 0)
                return true;
            else
                return false;
        }


        public override string ToString()
        {
            return $"Aluno: {nome} | Matricula: {matricula} | IRA: {ira}% | Email: {email}";
        }
        

    }
}
