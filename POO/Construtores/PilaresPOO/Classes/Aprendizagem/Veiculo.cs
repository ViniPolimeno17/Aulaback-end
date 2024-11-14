using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Veiculo
    {
        public string? marca { get; set; }
        public string? modelo { get; set; }
        public string? cor  { get; set; }
        public float potencia  { get; set; }
        public int qtdPassageiro  { get; set; }

        public void ligar()
        {
            Console.WriteLine($"Veiculo ligou!");
        }
        public void Desligar()
        {
            Console.WriteLine($"Veiculo desligou!");
        }
        public void Buzinar()
        {
            Console.WriteLine($"Biiiihhbihh!!!");   
        }







    }
}