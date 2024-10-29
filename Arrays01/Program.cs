Console.WriteLine(@" 
    ⬛⬛⬛⬛⬛🟩🟩⬛🟩🟩⬛⬛⬛
    ⬛⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛ 
    ⬛⬛⬛🟩🟩⬜⬛⬜⬜⬛🟩⬛⬛ 
    ⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟫🟫🟫🟫⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛⬛
            <Bem-Vindo>
");

int[] Num = new int[6];
int par = 0, impar = 0;
 
 for (int i = 0; i < Num.Length; i++)
 {
    Console.WriteLine($"Escreva o {i + 1}º número ");
    int numeros = int.Parse(Console.ReadLine()!); 
    Num[i] = numeros;  

    if (numeros % 2 == 0)
    {
        par++;
    }
    else
    {
        impar++;
    }
 }

 Console.Clear();

Console.WriteLine($"{par} numero(s) par(es):");
// 10 16            (laco de repeticao)

for (int i = 0; i < Num.Length; i++)
{
  if (Num[i] % 2 == 0)
  {
    Console.WriteLine($"Esses sao os numeros par(es): {i}");
  }
}
Console.WriteLine($"{impar} numero(s) impar(es):");
// 95 85 71 79             (laco de repeticao)

for (int v = 0; v < Num.Length; v++)
{
if (Num[v] % 2 == 1)
{
 Console.WriteLine($"Esses sao os numeros impar(es): {v}");    
}
}












