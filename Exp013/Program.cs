// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите первое число");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1%Num2==0)
{
    Console.WriteLine($"Первое число кратно второму");
}
else 
{
    double ost=Num1%Num2;
    Console.WriteLine($"остаток деления первого числа на второе равен {ost}/{Num2}");
}
Console.WriteLine();