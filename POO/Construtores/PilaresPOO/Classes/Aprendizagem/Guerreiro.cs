namespace PilaresPOO.Classes.Aprendizagem
{
    public class Guerreiro : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"Guerreiro bateu a espada!");
            // base.Atacar();
        }
    }
}