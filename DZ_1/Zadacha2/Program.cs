int a = new Random().Next(1,100);
Console.WriteLine(a.ToString());
int b = new Random().Next(1,100);
Console.WriteLine(b.ToString());

if(a > b)
{
    Console.WriteLine("max " + (a));
}
else
{
    Console.WriteLine("max " + (b));
}


/*
Вариант короткого решения:

int a = 5;
int b = 7;
Console.WriteLine("max " + (a > b ? a:b));
*/

