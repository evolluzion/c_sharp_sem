int a = new Random().Next(1,8);
Console.WriteLine(a);
if (a < 6)
{
    Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("Это выходной");
}

/*
Решение в одну строку:

int a = new Random().Next(1,8);
Console.WriteLine(a);
Console.WriteLine(a < 6 ? $"Это будний день" : $"Это выходной");
*/