// See https://aka.ms/new-console-template for more information
int A, B, C, D;
string linha = Console.ReadLine();
A = int.Parse(linha);
linha = Console.ReadLine();
B = int.Parse(linha);
linha = Console.ReadLine();
C = int.Parse(linha);
linha = Console.ReadLine();
D = int.Parse(linha);

var soma = ((A * B) - (C * D));

Console.WriteLine($"DIFERENCA = {soma}");