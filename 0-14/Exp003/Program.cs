// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер деня недали");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num>7||Num<1) Console.WriteLine("В недели 7 дней");
if (Num==1)Console.WriteLine("Это Понедельник"); 
if (Num==2)Console.WriteLine("Это Вторник"); 
if (Num==3)Console.WriteLine("Это Среда"); 
if (Num==4)Console.WriteLine("Это Четверг"); 
if (Num==5)Console.WriteLine("Это Пятница"); 
if (Num==6)Console.WriteLine("Это Суббота"); 
if (Num==7)Console.WriteLine("Это Воскресение"); 
Console.WriteLine();
