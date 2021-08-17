using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolidacaoGit
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}
