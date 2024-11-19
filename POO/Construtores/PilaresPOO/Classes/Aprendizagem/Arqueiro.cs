namespace PilaresPOO.Classes.Aprendizagem
{
    public class Arqueiro : Personagem
    {
       public override void Atacar()
        {
            Console.WriteLine($"Arqueiro atirou a flecha!");
            // base.Atacar();
        } 
    }
}
