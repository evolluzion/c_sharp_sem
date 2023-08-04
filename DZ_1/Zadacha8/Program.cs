int a = new Random().Next(1,100);
Console.WriteLine(a.ToString());
int b = 1;
while (b < a)
{
    Console.WriteLine(b + 1);
    b += 2;
}
