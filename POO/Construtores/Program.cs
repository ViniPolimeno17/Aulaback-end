using Construtores.Classes;

Console.Clear();
Console.WriteLine(@"
⬜⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜
⬜⬜⬛⬜⬜⬜⬜⬜⬛⬜⬜
⬜⬛⬜⬜⬜⬜⬜⬜⬜⬛⬜
⬛⬜⬜⬛⬛⬜⬛⬛⬜⬜⬛
⬛⬜⬛⬛⬛⬜⬛⬛⬛⬜⬛
⬛⬜⬛⬛⬛⬜⬛⬛⬛⬜⬛
⬛⬜⬛⬛⬜⬜⬜⬛⬛⬜⬛
⬛⬜⬜⬜⬜⬛⬜⬜⬜⬜⬛
⬜⬛⬜⬜⬜⬜⬜⬜⬜⬛⬜
⬜⬜⬛⬜⬛⬜⬛⬜⬛⬜⬜
⬜⬜⬛⬜⬛⬜⬛⬜⬛⬜⬜
⬜⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜
");

// Veiculo carro1 = new Veiculo("Ford","Mustang", 1967, "Azul");
// Veiculo carro2 = new Veiculo("Chevrolet", "Chevelle", 1967, "Champagne");

// Aluno aluno1 = new Aluno("Guilherme", "Desenvolvimento de Sistemas", 16, 233776542);
// Aluno aluno2 = new Aluno("Richard", "Desenvolvimento de Sistemas", 17, 233777762);

List<Jogo> estoqueJogos = new List<Jogo>();

Jogo jogo1 = new Jogo("God of War", 2005, "Ação-Aventura", 99.99f);	
Jogo jogo2 = new Jogo("NeedforSpeed", 2010, "Corrida", 100.99f);
Jogo jogo3 = new Jogo("Minecraft", 2008, "Sobrevivência", 89.99f);
Jogo jogo4 = new Jogo("legoºMarvel", 2016, "Ação-Aventura", 24.99f);

estoqueJogos.Add(jogo1);
estoqueJogos.Add(jogo2);
estoqueJogos.Add(jogo3);
estoqueJogos.Add(jogo4);

foreach (var jogo in estoqueJogos)
{
    Console.WriteLine($"Jogo: {jogo.nome}");
}


// Console.WriteLine($"<--Carros Registrados>");
// carro1.ExibirDados();
// carro2.ExibirDados();
Console.WriteLine($"<--Jogos Registrados-->");
jogo1.ExibirDados();
jogo2.ExibirDados();
// Console.WriteLine($"<--Alunos Registrados-->");
// aluno1.ExibirDados();
// aluno2.ExibirDados();


Jogo opcao = new Jogo();
do
{    
Console.WriteLine(@$"
    
    *--------------------------*
    |     Menu de opcoes 😁   |
    *--------------------------*
    |    0)Sair                |
    |    1)Cadastrar Jogo      |
    |    2)Listar Jogos        |
    *--------------------------*
    ");

opcao Console.ReadLine();

} while (opcao == "0");