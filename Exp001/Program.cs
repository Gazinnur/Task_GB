//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите числа");
int Num1=Convert.ToInt32(Console.ReadLine());
int Num2=Convert.ToInt32(Console.ReadLine());
if (Num1==Num2*Num2)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ квадрат для второго");
}
