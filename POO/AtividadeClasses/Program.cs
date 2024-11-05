using AtividadeClasses;
Console.Clear();
Console.WriteLine(@"
<--Bem-Vindo-->
─────▀▄▀─────▄─────▄
──▄███████▄──▀██▄██▀
▄█████▀█████▄──▄█
███████▀████████▀
─▄▄▄▄▄▄███████▀⠀");

Console.WriteLine(@$"*** Programa Fábrica de Carros! ***");

Veiculo F40 = new Veiculo();
// entrada/processamento
Console.WriteLine($"Qual é a marca do carro?");
F40.marca = Console.ReadLine();

Console.WriteLine($"Qual é o modelo?");
F40.modelo = Console.ReadLine();

Console.WriteLine($"Qual é a cor?");
F40.cor = Console.ReadLine();

Console.WriteLine($"Qual é a potência?");
F40.potencia = Console.ReadLine();

Console.WriteLine($"Quantas portas?");
F40.qtdPortas = int.Parse(Console.ReadLine()) ;

Console.WriteLine(@$"Carro: {F40.marca} {F40.modelo}!");




