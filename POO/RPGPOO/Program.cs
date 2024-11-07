// using RPGPOO;

using RPGPOO.Classes;

Personagens pers = new Personagens();

Console.Clear();
Console.WriteLine($"Qual o nome do personagem?");
pers.nome = (Console.ReadLine()!);

Console.WriteLine($"Qual a idade do seu personagem?");
pers.idade = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual armadura seu personagem usa?");
pers.armadura = (Console.ReadLine()!);

Console.WriteLine($"Qual IA seu personagem usa?");
pers.Ia = (Console.ReadLine()!);

Console.WriteLine($"Text");


Console.Clear();
string opcao = "";

Console.Write(@"
+===================+
| Escolha uma opcao |
+===================+

1)Agredir🤬
2)fugir😒
3)Melhorar escudo😎
R: ");

opcao = (Console.ReadLine()!);
if (opcao == "1")
{
    pers.Atacar();
}
else if (opcao == "2")
{
    pers.Defender();
}
else if (opcao == "3")
{
    pers.RestaurarArmadura();
}
else
{
    Console.WriteLine($"Opcao Invalida :(");
}