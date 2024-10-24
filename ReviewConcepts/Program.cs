Console.WriteLine(@" 
    ⬛⬛⬛⬛⬛🟩🟩⬛🟩🟩⬛⬛⬛
    ⬛⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛ 
    ⬛⬛⬛🟩🟩⬜⬛⬜⬜⬛🟩⬛⬛ 
    ⬛⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟫🟫🟫🟫⬛⬛⬛
    ⬛⬛🟩🟩🟩🟩🟩🟩🟩⬛⬛⬛⬛
");


Console.WriteLine($"Olá, digite seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Olá, {nome} qual seu sobrenome: ");
string sobrenome = Console.ReadLine()!;


Console.WriteLine($"digite seu E-mail: ");
string email = Console.ReadLine()!;

Console.WriteLine($"digite seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"digite seu CPF: ");
UInt128 cpf = UInt128.Parse (Console.ReadLine()!);

Console.WriteLine($"digite seu endereço: ");
string endereço = Console.ReadLine()!;

Console.WriteLine($"digite seu estado civil: ");
string estadocivil = Console.ReadLine()!;


Console.WriteLine($"Em que ano voce nasceu ");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
// int anoNascimento = anoAtual - idade;
int idade = anoAtual - anoNascimento;

Console.Clear();
Console.WriteLine(@$"Seus dados são:
{nome} {sobrenome}
{idade}
{email}
{telefone}
{cpf}
{endereço}
{estadocivil}
{idade}");

