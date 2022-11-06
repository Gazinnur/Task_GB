// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер деня недали");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num>7||Num<1)
{
    Console.WriteLine("В недели 7 дней");
    
}
else 
{if (Num<6)
    {
        Console.WriteLine("Это будний день");
    }
    else Console.WriteLine("Это выходной");
}