
using ClasseObjeto.Classes;

Console.WriteLine(@"
<--Bem-Vindo-->
─────▀▄▀─────▄─────▄
──▄███████▄──▀██▄██▀
▄█████▀█████▄──▄█
███████▀████████▀
─▄▄▄▄▄▄███████▀⠀");

Animal cachorro = new Animal();
Animal gato = new Animal();

cachorro.especie = "Vira-Lata";
cachorro.cor = "Caramelo";
cachorro.nome = "Caramelo";
cachorro.idade = 3;

gato.especie = "Sphynx";
gato.cor = "Cinza";
gato.nome = "Cleópatra";
gato.idade = 6;


cachorro.FazerBarulho("Au Au");
cachorro.Envelhecer();
Console.WriteLine($"Nome: {cachorro.nome}");
Console.WriteLine($"Especie do {cachorro.nome}: {cachorro.especie}");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade}");

gato.FazerBarulho("Miau Miau");
gato.Envelhecer();
Console.WriteLine($"Nome: {gato.nome}");
Console.WriteLine($"Especie do {gato.nome}: {gato.especie}");
Console.WriteLine($"Cor do {gato.nome}: {gato.cor}");
Console.WriteLine($"Idade do {gato.nome}: {gato.idade}");







