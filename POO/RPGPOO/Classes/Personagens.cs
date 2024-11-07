namespace RPGPOO.Classes
{
    public class Personagens
    {
        public string? nome;

        public int? idade;

        public string? armadura;

        public string? Ia;

        public void Atacar()
        {
            Console.WriteLine($"O {nome} Atacou!");
        }
        public void Defender()
        {
            Console.WriteLine($"O {nome} Fugiu!");
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O {nome} restaurou a armadura!");
        }
    }

}
