// Написать программу вычисления значения функции y = f(a)
Console.WriteLine("y=sin(x)");
Console.WriteLine("Введите х");
double x = Convert.ToDouble(Console.ReadLine());
double y = Math.Sin(x);
Console.WriteLine($"в уравнении y=sin(x) при х = {x} y = {y}");