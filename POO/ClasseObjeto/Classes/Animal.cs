using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseObjeto.Classes

{
    public class Animal
    {
        public string? especie;
        public string? cor;
        public string? nome;
        public int idade = 0;

        public void FazerBarulho(string barulho = "Barulho Genérico")
        {
            Console.WriteLine($"Som do animal: {barulho}");      
        }
        // class cachorro : Animal;
        // public override void FazerBarulho()
        // {
        //     Console.WriteLine($"Au Au Au");   
        // }
        // class gato : Animal;
        // public override void FazerBarulho()
        // {
        //     Console.WriteLine($"Miau Miau Miau");   
        // }

        // Animal somCachorro = new cachorro();
        // Animal somGato = new gato();

        public void Envelhecer()
        {
            idade++;
        }
    }
}




