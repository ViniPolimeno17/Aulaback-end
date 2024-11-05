// 2) Crie um novo projeto C# chamado Calculator e o abra no VSCode. Dentro do projeto crie uma pasta  “Classes” e cria uma classe Calculadora com as segufloates propriedades e métodos 

// Propriedades:
// numero1 float
// numero2 float
// Métodos - todos devem retornar void e receber os dois números por parâmetro
// Somar()
// Subtrair()
// Multiplicar()
// Dividir()
namespace Calculator.Classes.Calculadora;

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

Calculadora numero1 = new Calculadora();
Calculadora numero2 = new Calculadora();


Console.WriteLine($"Escreva um numero");
 float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Escreva um numero");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine({Somar()});
Console.WriteLine({Subtração()});
Console.WriteLine({Multiplicação()});
Console.WriteLine({Divisão()});


