// 2) Crie um novo projeto C# chamado Calculator e o abra no VSCode. Dentro do projeto crie uma pasta  “Classes” e cria uma classe Calculadora com as segufloates propriedades e métodos 

// Propriedades:
// numero1 float
// numero2 float
// Métodos - todos devem retornar void e receber os dois números por parâmetro
// Somar()A
// Subtrair()
// Multiplicar()
// Dividir()
using Calculator.Classes;

Console.Clear();
Console.WriteLine($@"
             <--Bem-vindo ao NuBankinho-->
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬛⬛
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬛
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬛⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬛⬛⬛⬛⬜⬜⬜⬛⬛⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬛⬛🟦🟦⬛⬛⬜⬜⬛⬛⬜
⬜⬜⬜⬜⬛⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬛⬛🟦🟦⬛⬛⬜⬛⬛⬜⬜
⬜⬜⬜⬛⬛⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬜⬜⬛⬛⬜⬜
⬜⬜⬜⬛⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬛⬛⬜⬜⬜
⬜⬜⬛⬛⬜⬛⬛⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜
⬜⬜⬛⬛⬜⬛⬛⬜⬜⬜⬜⬛⬛⬛⬛⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜
⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜
⬜⬛⬛⬛⬛⬛⬛⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜🟧🟨🟨⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜
⬜⬜🟧🟧🟨🟨🟨🟨⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜🟥🟥🟧🟨🟨🟨🟨⬛⬛⬛⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
🟧🟥🟥🟥🟧🟨🟨🟨🟨🟨🟨⬜⬜⬛⬛⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜🟥🟧🟨🟨🟨🟨🟨🟧⬛⬛⬛⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜🟥🟥🟥🟧🟨🟨🟧🟨🟥⬛⬛⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜🟥🟥🟥🟥🟧🟧🟥🟧🟨🟥⬛⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜
🟧🟥🟥🟥🟥🟥🟥🟥🟥🟧🟥⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
🟥⬜⬜⬜🟥🟥🟥🟧🟥🟧⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜🟥🟥🟥⬜🟥🟥⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜🟥🟧⬜⬜🟥🟧⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜");

Calculadora calc = new Calculadora();


Console.WriteLine($"Escreva um numero");
float numero1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Escreva um numero");
float numero2 = float.Parse(Console.ReadLine()!);

calc.numero1 = numero1;
calc.numero2 = numero2;

Console.WriteLine(@"
    <-Escolha a operação->
    1- Adição
    2- Subtração
    3- Multiplicação
    4- Divisão");
string operacoes = Console.ReadLine()!;

if (operacoes == "1")
{
    calc.Somar();    
    Console.WriteLine();
}
if (operacoes == "2")
{
    calc.Subtrair();
    Console.WriteLine();
    
}
else if (operacoes == "3")
{
    calc.Multiplicacao();
    Console.WriteLine();
    
}
else if(operacoes == "4")
{
    calc.Divisao();
}
else
{
    Console.WriteLine($"Conta inválida!!!");
}


