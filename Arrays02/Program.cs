Console.WriteLine(@" 
    ⬛⬛⬛⬛⬛🟩🟩⬛🟩🟩⬛⬛⬛
    ⬛⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛ 
    ⬛⬛⬛🟩🟩⬜⬛⬜⬜⬛🟩⬛⬛ 
    ⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟫🟫🟫🟫⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛⬛
            <Bem-Vindo>
");


int[] numero10 = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
int[] numeros =  {11, 12, 13, 14, 15, 16, 17, 18, 19};

for (int i = 0; i < numero10.Length; i++)
{
    if (i % 2 == 0)
    {
    Console.WriteLine($"{numero10[i]}");
    }
    else
    {
    Console.WriteLine($"{numeros[i]}");    
    }
Console.WriteLine($"{numeros[i]}, {numero10[i]}");
}

