// Найти максимальное из трех чисел
Console.WriteLine("Введите 3 числа");
int Num1=Convert.ToInt32(Console.ReadLine());
int Num2=Convert.ToInt32(Console.ReadLine());
int Num3=Convert.ToInt32(Console.ReadLine());
int max=Num1;

if (Num2>max)
{
    max=Num2;
}
if(Num3>max) max=Num3;
Console.WriteLine($"Max = {max}");