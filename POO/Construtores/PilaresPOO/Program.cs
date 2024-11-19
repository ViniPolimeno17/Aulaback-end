using PilaresPOO.Classes.Aprendizagem;
using PilaresPOO.Classes.Pilares;

Console.Clear();

Console.WriteLine(@"⠀

⠀ ⢀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⣀⣠⣤⡤⠖⠚⠁
⠀⣰⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⢀⣀⣠⣤⣴⣶⡿⠿⠛⠉⠀⠀⠀⠀⠀
⢰⣿⣿⣧⣀⣀⣀⣀⣀⣤⣴⣶⣶⣿⣿⣿⠿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠙⢿⣿⣿⣿⣿⡿⠿⠛⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
");

ContaCorrente ctVini = new ContaCorrente();
ctVini.Titular = "Vinicius Bernardo";
ctVini.Depositar(100000f);
// ctVini.Saldo = 0;
Console.WriteLine($"Titular da Conta: {ctVini.Titular}");
Console.WriteLine($"Saldo da Conta: {ctVini.getSaldo()}");

float valorSacado = ctVini.Sacar(1200f);

Console.WriteLine($"Valor do Saque: {valorSacado}");
Console.WriteLine($"Novo Saldo: {ctVini.getSaldo()}");




