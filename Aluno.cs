using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    public class Aluno
    {
        public int matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
        public int Matricula
        {
            set
            {
                if (matricula <= 0)
                {
                    return;
                }
                matricula = value;
            }
            get
            {
                return matricula;
            }
        }
    }
}
