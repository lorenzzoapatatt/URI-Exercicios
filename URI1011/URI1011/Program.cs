double A = double.Parse(Console.ReadLine());
double pi = 3.14159;
var volume = (pi * Math.Pow(A , 3) * 4/3);

Console.WriteLine($"VOLUME = {volume.ToString("F3")}");