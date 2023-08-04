int a = new Random().Next(1,100);
Console.WriteLine(a.ToString());
if(a % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}