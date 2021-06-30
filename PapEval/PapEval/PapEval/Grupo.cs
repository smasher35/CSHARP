using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapEval
{
    [Serializable]
    public class Grupo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string aluno1 { get; set; }
        public string aluno2 { get; set; }
        public string aluno3 { get; set; }
        public int presentationGrade { get; set; }
        public int reportGrade { get; set; }
        public int projectGrade { get; set; }
        public int finalGrade { get; set; }
        public string obs { get; set; }
    }
}
