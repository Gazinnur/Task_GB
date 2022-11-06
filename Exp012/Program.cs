//Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трехначное число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num > 99 && Num <= 999)
{
    int Third = Num % 10;
    int first = Num /100;
    Console.WriteLine($"{first}{Third}");
}
else if (Num < -99 && Num >=-999)
{
    int Third = -Num % 10;
    int first = Num /100;
    Console.WriteLine($"{first}{Third}");
}
else Console.WriteLine("Вы ввели не трехначное число");


Console.WriteLine();
