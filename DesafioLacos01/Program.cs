// [ ] DesafioLaco 01: Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// O número de pessoas que responderam SIM;
// O número de pessoas que responderam NÃO;
// O número de mulheres que responderam SIM;
// A porcentagem de homens que responderam NÃO entre todos os homens analisados
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

for(int cota = 1; cota <= 10; cota++){
    Console.WriteLine($"Qual seu Sexo? m/f");
    string sexo = Console.ReadLine()!;   
    Console.WriteLine($"Você gostou do nosso produto? s/n");
    string gostaProduto = Console.ReadLine()!;

    if (sexo == "f")
{
    qtdMulher++;
}
else
{
    qtdHomem++; 
}
if (gostaProduto == "s")
{
    qtdGostao++; 
}
else
{
    qtdNGostao++;
}
}
float percentual = (100/qtdHomem) * qtdNGostao;

Console.WriteLine($"Quantidade de Mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de Homens: {qtdHomem}");
Console.WriteLine($"Pessoas que gostaram do produto: {qtdGostao}");
Console.WriteLine($"Pessoas que não gostaram do produto: {qtdNGostao}");
Console.WriteLine($"Total de entrevistados: {qtdMulher + qtdHomem}");
Console.WriteLine($"Percentual dos homens que não gostaram: {percentual}%");
