
Console.WriteLine(@" 
    ⬛⬛⬛⬛⬛🟩🟩⬛🟩🟩⬛⬛⬛
    ⬛⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛ 
    ⬛⬛⬛🟩🟩⬜⬛⬜⬜⬛🟩⬛⬛ 
    ⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟫🟫🟫🟫⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛⬛
");

Console.WriteLine("insira a sua frequencia (0% a 100&)");
int frequencia = int.Parse(Console.ReadLine()!);

if ( frequencia < 75) {
    Console.WriteLine($"Reprovado, será CLT");
    
} else {
    Console.WriteLine($"Otimo, podemos começar a avaliar");
}

Console.WriteLine($"Insira suas medias (0 a 10)");
int media1 = int.Parse (Console.ReadLine()!);
int media2 = int.Parse (Console.ReadLine()!);
int media3 = int.Parse (Console.ReadLine()!);
int media4= int.Parse (Console.ReadLine()!);

int notatotal = media1 + media2 + media3 + media4 ;
int notafinal = notatotal /4;

if (notafinal >= 7) {
    Console.WriteLine($@"Voce foi aprovado.
    Nota final : {notafinal}");
} else if (notafinal <7) {
    Console.WriteLine($@"Voce esta de recuperação.
    Nota final : {notafinal}");
    
} else if (notafinal == 0){
    Console.WriteLine($@"Voce foi reprovado, será CLT.
    Nota final : {notafinal}");
} else {
    Console.WriteLine($"FAZ O NEGOCIO DIREITO CLT!!");
    
}

