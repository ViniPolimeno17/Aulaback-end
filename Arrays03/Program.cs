//[ ] DesafioArray03: Faça um programa que receba a temperatura média de cada mês do ano e armazene essas temperaturas em um vetor. Calcule e imprima a maior e a menor temperatura do ano.

int []temperatura = new int[12];

for ( int i = 0; i < temperatura.Length; i++){
    Console.WriteLine($@"Insira abaixo a temperatura do mês {i + 1}:");

    temperatura[i] = int.Parse(Console.ReadLine()!);
}
int maiortemperatura = temperatura.Max();
int menortemperatura = temperatura.Min();

Console.WriteLine($"Maior temperatura foi: { maiortemperatura}");
Console.WriteLine($"Menor temperatura foi: {menortemperatura}");

