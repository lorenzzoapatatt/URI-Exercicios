using System.Globalization;

string[] linha = Console.ReadLine().Split(' ');

double A = double.Parse(linha[0], CultureInfo.InvariantCulture);
double B = double.Parse(linha[1], CultureInfo.InvariantCulture);
double C = double.Parse(linha[2], CultureInfo.InvariantCulture);
double pi = 3.14159;
var triangulo = (A * C)/2;
var circulo = pi * (Math.Pow(C, 2));
var trapezio = ((A + B) * C) / 2;
var quadrado = Math.Pow(B, 2);
var retangulo = A * B;

Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
