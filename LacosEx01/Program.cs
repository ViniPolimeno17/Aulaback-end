using System.Runtime.Intrinsics.Arm;

Console.WriteLine(@" 
    ⬛⬛⬛⬛⬛🟩🟩⬛🟩🟩⬛⬛⬛
    ⬛⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛ 
    ⬛⬛⬛🟩🟩⬜⬛⬜⬜⬛🟩⬛⬛ 
    ⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟫🟫🟫🟫⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛⬛
            <Bem-Vindo>
");
int qtdMulher = 0;
int qtdHomem = 0;
int qtdGostao = 0;
int qtdNGostao = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtddePessoas = int.Parse(Console.ReadLine()!);

for(int cota = 1; cota <= qtddePessoas; cota++){
    Console.WriteLine($"Qual seu Sexo? m/f");
    string sexo = Console.ReadLine()!;   
    Console.WriteLine($"Você gosta de esportes? s/n");
    string gostadeEsporte = Console.ReadLine()!;

    if (sexo == "f")
{
    qtdMulher++;
}
else
{
    qtdHomem++; 
}

if (gostadeEsporte == "s")
{
    qtdGostao++; 
}
else
{
    qtdNGostao++;
}
}

float percentual = (100/qtddePessoas) * qtdGostao;
float porcentagem = (100/qtddePessoas) * qtdNGostao;

Console.WriteLine($"Quantidade de Mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de Homens: {qtdHomem}");
Console.WriteLine($"Pessoas que gostam de esportes: {qtdGostao}");
Console.WriteLine($"Pessoas que não gostam de esportes: {qtdNGostao}");
Console.WriteLine($"Total de entrevistados: {qtddePessoas}");
Console.WriteLine($"Percentual das pessoas que gostam: {percentual}%");
Console.WriteLine($"Percentual das pessoas que não gostam: {porcentagem}%");



