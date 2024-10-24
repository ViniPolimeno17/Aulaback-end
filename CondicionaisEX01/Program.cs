Console.WriteLine(@" 
    ⬛⬛⬛⬛⬛🟩🟩⬛🟩🟩⬛⬛⬛
    ⬛⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛ 
    ⬛⬛⬛🟩🟩⬜⬛⬜⬜⬛🟩⬛⬛ 
    ⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟫🟫🟫🟫⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛⬛
");

Console.WriteLine($"Olá, Qual seu salario? ");
float Salario = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Olá, Quanto você gastou? ");
float Gastos = float.Parse(Console.ReadLine()!);

if (Salario >= Gastos){
    Console.WriteLine($"Você ta dentro do limite");
}
else
{
    Console.WriteLine($"Você estorou seu limite ");
}

float saldoDisponivel = Salario - Gastos;
Console.WriteLine($"Seu saldo disponivel é: {saldoDisponivel}");
