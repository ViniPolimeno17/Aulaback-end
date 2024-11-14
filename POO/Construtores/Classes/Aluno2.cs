using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno2
    {
        public string Nome;
        public int CPF;

        public Aluno2() { }

        public Aluno2(string _chuchu)
        {
            Nome = _chuchu;
        }
        public Aluno2(string _xuxu, int seuPF)
        {
            Nome = _xuxu;
            CPF = seuPF;
        }
    }
}