// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int[] array = new int[25];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = Random.Shared.Next(10, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int max = array[0];
for (int i = 1; i < length; i++)
{
    if (array[i] > max) max = array[i];
}
Console.WriteLine($"Max Number in array is {max}");


// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine();
int Num = Random.Shared.Next(10, 100);
Console.WriteLine($"Random Number is {Num}");
int Maxfigure = Num/10;
if (Num%10> Maxfigure) Maxfigure = Num%10;
Console.WriteLine($"Max figure of Random Number is {Maxfigure}");

