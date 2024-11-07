using System;

class Carros
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O Carro faz um som.");
    }
}

class Polo : Carros
{
    public override void FazerSom()
    {
        Console.WriteLine("O polo faz vrrrrrrrr!.");
    }
}

class Mini : Carros
{
    public override void FazerSom()
    {
        Console.WriteLine("O mini faz rammmm pahh!!.");
    }
}
class Beetle : Carros
{
    public override void FazerSom()
    {
        Console.WriteLine("O beetle faz tru tru tu tu!!.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Carros meuCarro = new Carros();
        Carros meuPolo = new Polo();
        Carros meuMini = new Mini();
        Carros meuBeetle = new Beetle();

        meuCarro.FazerSom();
        meuPolo.FazerSom(); 
        meuMini.FazerSom();
        meuBeetle.FazerSom(); // Saída: O fusca range a correia.
    }
}

