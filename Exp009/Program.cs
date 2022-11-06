// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехначное число");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num < 0) Num = -Num;
if (Num > 99 && Num <= 999)
{
    int Third = Num % 10;
    Console.WriteLine(Third);
}
else Console.WriteLine("Вы ввели не трехначное число");

