using Banco;

Console.Clear();
Console.WriteLine($@"
             <--Bem-vindo ao NuBankinho-->
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬛⬛
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬛
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬛⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬛⬛⬛⬛⬜⬜⬜⬛⬛⬜
⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬛⬛🟦🟦⬛⬛⬜⬜⬛⬛⬜
⬜⬜⬜⬜⬛⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬛⬛🟦🟦⬛⬛⬜⬛⬛⬜⬜
⬜⬜⬜⬛⬛⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬛⬛⬛⬛⬜⬜⬛⬛⬜⬜
⬜⬜⬜⬛⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬛⬛⬜⬜⬜
⬜⬜⬛⬛⬜⬛⬛⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜
⬜⬜⬛⬛⬜⬛⬛⬜⬜⬜⬜⬛⬛⬛⬛⬜⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜
⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜
⬜⬛⬛⬛⬛⬛⬛⬜⬜⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜
⬜⬜⬜⬜⬜🟧🟨🟨⬛⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜
⬜⬜🟧🟧🟨🟨🟨🟨⬛⬛⬛⬛⬜⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜🟥🟥🟧🟨🟨🟨🟨⬛⬛⬛⬜⬜⬜⬜⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
🟧🟥🟥🟥🟧🟨🟨🟨🟨🟨🟨⬜⬜⬛⬛⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜🟥🟧🟨🟨🟨🟨🟨🟧⬛⬛⬛⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜🟥🟥🟥🟧🟨🟨🟧🟨🟥⬛⬛⬜⬜⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜
⬜🟥🟥🟥🟥🟧🟧🟥🟧🟨🟥⬛⬛⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜
🟧🟥🟥🟥🟥🟥🟥🟥🟥🟧🟥⬛⬛⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
🟥⬜⬜⬜🟥🟥🟥🟧🟥🟧⬜⬛⬛⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜🟥🟥🟥⬜🟥🟥⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜
⬜⬜⬜🟥🟧⬜⬜🟥🟧⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜⬜");
Console.WriteLine();

ContaCorrente contaGui = new ContaCorrente();
ContaCorrente contaVini = new ContaCorrente();

contaGui.Titular = "Guilherme";
contaGui.Depositar(1000000f);

contaVini.Titular = "Vinicius";
contaVini.Depositar(10000000f);

Console.WriteLine($"Conta da {contaGui} tem R$ {contaGui.Saldo}");
Console.WriteLine($"Conta da {contaVini} tem R$ {contaVini.Saldo}");

contaVini.Sacar(250f);

Console.WriteLine($"Você sacou e sua conta ficou com R$ {contaVini.Saldo}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Conta da {contaGui} tem R$ {contaGui.Saldo}");
Console.WriteLine($"Conta da {contaVini} tem R$ {contaVini.Saldo}");
Console.WriteLine();