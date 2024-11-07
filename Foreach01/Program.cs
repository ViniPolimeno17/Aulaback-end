string[] frutas = {"Melao", "Melancia", "Carambola", "Jabuticaba", "Maracúja", "Morango", "Abacate", "Acerola", "Pitanga", "Pitaia", "Lichia","Caja", "Kiwi", "Banana", "Groselia", "Limão"};

Console.WriteLine($"Sua sacola contém {frutas.Length} frutas:");

foreach (string f in frutas)
{
   Console.WriteLine($"{f}, ");   
}

Console.WriteLine();


