// Показать четные числа от 1 до N

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N<0) N=-N;
for (int i = 1; i <=N; i++)
{
    if (i%2==0)
    {
        Console.Write($"{i} ");
    }
}
