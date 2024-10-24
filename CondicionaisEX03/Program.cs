Console.WriteLine(@" 
    ⬛⬛⬛⬛⬛🟩🟩⬛🟩🟩⬛⬛⬛
    ⬛⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛ 
    ⬛⬛⬛🟩🟩⬜⬛⬜⬜⬛🟩⬛⬛ 
    ⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟫🟫🟫🟫⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛⬛
");

// 3) Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

//    − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
//    − Triângulo    Isóscele:    possui    2    lados    iguais.     
//    − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.Write("Digite o comprimento do primeiro lado: ");
float lado1 = float.Parse(Console.ReadLine()!);

Console.Write("Digite o comprimento do segundo lado: ");
float lado2 = float.Parse(Console.ReadLine()!);

Console.Write("Digite o comprimento do terceiro lado: ");
float lado3 = float.Parse(Console.ReadLine()!);

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("O triângulo é Equilátero.");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("O triângulo é Isósceles.");
}
else
{
    Console.WriteLine("O triângulo é Escaleno.");
}
