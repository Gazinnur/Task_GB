//Показать числа от -N до N
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0) N = -N;
for (int i = -N; i <= N; i++)
{
    Console.Write($"{i} ");
}
