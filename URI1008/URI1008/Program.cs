int A, B;
double C;
string linha = Console.ReadLine();
A = int.Parse(linha);
linha = Console.ReadLine();
B = int.Parse(linha);
linha = Console.ReadLine();
C = double.Parse(linha);

Console.WriteLine($"NUMBER = {A}");
Console.WriteLine($"SALARY = {B * C}");