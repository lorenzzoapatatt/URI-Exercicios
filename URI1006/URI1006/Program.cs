double A = double.Parse(Console.ReadLine());
double B = double.Parse(Console.ReadLine());
double C = double.Parse(Console.ReadLine());
var media = ((A * 2) + (B * 3) + (C * 5)) / 10;

Console.WriteLine($"MEDIA = {media.ToString("F1")}");
