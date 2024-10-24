string[] carros = new string[3];

// Console.WriteLine($"Digite qual carro você quer cadastrar");
// carros[0] = Console.ReadLine()!;

// Console.WriteLine($"Digite qual carro você quer cadastrar");
// carros[1] = Console.ReadLine()!;

// Console.WriteLine($"Digite qual carro você quer cadastrar");
// carros[2] = Console.ReadLine()!;


for (int i = 0; i < carros.Length; i++)
{
    Console.WriteLine($"Digite qual carro você quer cadastrar");
    carros[i] = Console.ReadLine()!;
}


Console.WriteLine($"O carro cadastrados: {carros[0]}, {carros[1]}, {carros[2]}");