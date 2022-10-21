using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadeF
{
    public class Alunos
    {
        public int matricula;
        public string nome_aluno;
        public string endereco_aluno;
        public string UF;
        public string tipo_curso;
        public string nome_curso;
        public string polo;
        public string modaliade_ensino;

        public void TrocarPolo(string novo)
        {
            this.polo = novo;
        }

        public bool MudarSe(int matricula)
        {
            if(matricula == this.matricula)
            {
                this.matricula = matricula;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
