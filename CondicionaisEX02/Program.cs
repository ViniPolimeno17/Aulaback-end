Console.WriteLine(@" 
    ⬛⬛⬛⬛⬛🟩🟩⬛🟩🟩⬛⬛⬛
    ⬛⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛ 
    ⬛⬛⬛🟩🟩⬜⬛⬜⬜⬛🟩⬛⬛ 
    ⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟫🟫🟫🟫⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛⬛
");

Console.WriteLine($"Olá, Quantos gols seu time fez? ");
int Time1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Eh Quantos gols o outro time fez? ");
int Time2 = int.Parse(Console.ReadLine()!);

if (Time1 > Time2)
{
    Console.WriteLine($"O resultado foi {Time1}x{Time2} seu time venceu");
}
else if (Time1 < Time2)
{
    Console.WriteLine($"O resultado foi {Time1}x{Time2} outro time venceu ");
}
else
{
    Console.WriteLine($"{Time1}x{Time2} Deu Empate!!");
}

