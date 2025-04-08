using System.Globalization;

string[] linha = Console.ReadLine().Split(' ');

int A = int.Parse(linha[0]);// nao precisa (nome)
int B = int.Parse(linha[1]);
double C = double.Parse(linha[2],CultureInfo.InvariantCulture);
var mult1 = B * C;

linha = Console.ReadLine().Split(' ');
int D = int.Parse(linha[0]);// nao precisa (nome)
int E = int.Parse(linha[1]);
double F = double.Parse(linha[2],CultureInfo.InvariantCulture);
var mult2 = E * F;
var somatotal = mult1 + mult2;

Console.WriteLine($"VALOR A PAGAR: R$ {somatotal.ToString("F2",CultureInfo.InvariantCulture)}");