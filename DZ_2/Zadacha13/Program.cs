int a = new Random().Next(1,10000);
Console.WriteLine(a);
if (a <= 99)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    while (a > 999)
    {
        a = a / 10;
    }
    Console.WriteLine("Третья цифра числа " + (a % 10));
}


/*
Вариант через ToString:

int a = new Random().Next(1,10000);
Console.WriteLine(a);
Console.WriteLine(a > 99 ? a.ToString()[2] : $"Третьего числа нет");
*/