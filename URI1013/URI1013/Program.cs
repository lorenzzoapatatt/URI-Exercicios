string[] linha = Console.ReadLine().Split(' ');

int A = int.Parse(linha[0]);
int B = int.Parse(linha[1]);
int S = int.Parse(linha[2]);

var maiorAB = ((A + B) + Math.Abs(A-B) ) / 2;

var maiorS = ((maiorAB + S) + Math.Abs(maiorAB - S)) / 2;
Console.WriteLine($"{maiorS} eh o maior");