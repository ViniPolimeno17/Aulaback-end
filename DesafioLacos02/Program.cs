// [ ] DesafioLaco02: Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// Total de Homens;
// Total de Mulheres;
// Média de idade dos Homens;
// Média de idade das mulheres.
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
int somaHomem = 0;
int somaMulher = 0;


for(int cota = 1; cota <= 4; cota++){
    Console.WriteLine($"Olá, Quantos anos você tem?");
    int idade = int.Parse(Console.ReadLine()!);  

    Console.WriteLine($"Quanto você pesa");
    float peso = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"Qual seu Sexo? m/f");
    string sexo = Console.ReadLine()!;

        if (sexo == "f")
{
    qtdMulher++;

    somaMulher += idade;
}
else
{
    qtdHomem++; 
    
    somaHomem += idade;
}
}
float percentualH = somaHomem / qtdHomem;
float percentualM = somaMulher / qtdMulher;

Console.WriteLine($"Quantidade de Mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de Homens: {qtdHomem}");
Console.WriteLine($"Média de idade dos Homens: {percentualH}");
Console.WriteLine($"Média de idade das Mulheres: {percentualM}");
