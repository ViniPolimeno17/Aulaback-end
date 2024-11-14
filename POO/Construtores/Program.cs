using System.Net.WebSockets;
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

// List<Jogo> estoqueJogos = new List<Jogo>();

// // Jogo jogo1 = new Jogo("God of War", 2005, "Ação-Aventura", 99.99f);	
// // Jogo jogo2 = new Jogo("NeedforSpeed", 2010, "Corrida", 100.99f);
// // Jogo jogo3 = new Jogo("Minecraft", 2008, "Sobrevivência", 89.99f);
// // Jogo jogo4 = new Jogo("legoºMarvel", 2016, "Ação-Aventura", 24.99f);

// // estoqueJogos.Add(jogo1);
// // estoqueJogos.Add(jogo2);
// // estoqueJogos.Add(jogo3);
// // estoqueJogos.Add(jogo4);

// foreach (var jogo in estoqueJogos)
// {
//     Console.WriteLine($"Jogo: {jogo.nome}");
// }


// Console.WriteLine($"<--Carros Registrados>");
// carro1.ExibirDados();
// carro2.ExibirDados();
// // Console.WriteLine($"<--Jogos Registrados-->");
// // jogo1.ExibirDados();
// // jogo2.ExibirDados();
// Console.WriteLine($"<--Alunos Registrados-->");
// aluno1.ExibirDados();
// aluno2.ExibirDados();


// Jogo opcao = new Jogo();
// do
// {



// Console.Write(@$"
    
//     --------------------------
//     |     Menu de opcoes 😁   |
//     --------------------------
//     |    1)Cadastrar Jogo      |
//     |    2)Listar Jogos        |
//     |    0)Sair                |
//     --------------------------
//     Resposta:
//     ");
//  opcao = Console.ReadLine();

//  if (opcao == "1")
// {
//     Console.Write("Qual o Nome do Jogo ?");
//     Cadastro.no = (Console.ReadLine()!);

//     Console.Write("Qual a data de lançamento do lançamento ?");
//     Cadastro.lan = (Console.ReadLine()!);

//     Console.Write("Qual o genero do jogo ?");
//     Cadastro.ge = (Console.ReadLine()!);

//     Console.WriteLine("Qual o preço do jogo ?");
//     Cadastro.pre = (Console.ReadLine()!);
//     jogos.Add(Cadastro);

    
// } else if (opcao == "2")
// {
//     foreach (var item in jogos)  
//     {  
//         ExibirDados({item});
//     }  
// } else if (opcao == "3"){

//     Console.Write("Obrigado por utilizar nosso programa !")

// } else {
//     Console.WriteLine($"Opcao inavlida ! 😒");
// }

// } while (opcao == 3);

Aluno2 yasminMula = new Aluno2("Yasmin Quadrupade");
yasminMula.CPF = 333;
Aluno2 yasBananinha = new Aluno2("Yas Boboca");
yasBananinha.CPF = 777;

Aluno2 yasminhasBolas = new Aluno2("Yasmin Cabrito", 444);


Console.WriteLine($"{yasminMula.Nome}");
Console.WriteLine($"{yasminMula.CPF}");

Console.WriteLine($"{yasBananinha.Nome}");
Console.WriteLine($"{yasBananinha.CPF}");

Console.WriteLine($"{yasminhasBolas.Nome}");
Console.WriteLine($"{yasminhasBolas.CPF}");



