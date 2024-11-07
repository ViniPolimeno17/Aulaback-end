using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
         public string nome { get; set; }

        public string curso { get; set; }
        public int idade { get; set; }

        public int cpf { get; set; }


        public Aluno(string no, string cu, int id, int cp)
        {
            nome = no;
            curso = cu;
            idade = id;
            cpf = cp;

            Console.WriteLine($"O ALuno foi registrado");

        }
         public void ExibirDados()
        {
            Console.WriteLine(@$"
            Nome: {nome}
            Curso: {curso}
            Idade: {idade}
            CPF: {cpf}
            ");
            
        }
    }
}