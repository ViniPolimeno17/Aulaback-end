namespace PilaresPOO.Classes.Aprendizagem
{
    public class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"Mago lançou Fireball!");
            // base.Atacar();
        }
    }
}