// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 0)Num=-Num;
if (Num < 99 && Num > -99) Console.WriteLine("третьего числа нет");
else {if (Num > 1000)
{
    Num=Num/10;
}
Console.WriteLine($"{Num%10}");}

Console.WriteLine();