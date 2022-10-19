double m = 2;
double b = 0.7;
double c = -1;
double t = 1.2;

Console.WriteLine("Входные значения:");
Console.WriteLine($"Переменная m: {m}");
Console.WriteLine($"Переменная b: {b}");
Console.WriteLine($"Переменная c: {c}");
Console.WriteLine($"Переменная t: {t}");


double f = Math.Sqrt(m*Math.Tan(t)+Math.Abs(c*Math.Sin(t)));
Console.WriteLine("");
Console.WriteLine($"Значение первого выражения F: {f}");


double z = m*Math.Cos(b*t*Math.Sin(t))+c;
Console.WriteLine("");
Console.WriteLine($"Значение второго выражения Z: {z}");