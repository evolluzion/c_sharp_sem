/*По лекции*/

int a = new Random().Next(1,100);
Console.WriteLine(a.ToString());
int b = new Random().Next(1,100);
Console.WriteLine(b.ToString());
int c = new Random().Next(1,100);
Console.WriteLine(c.ToString());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

/*
Другое решение:

int a = 2;
int b = 3;
int c = 7;
int max = a;
max = b > a ? b : a;
max = max > c ? max : c;
Console.WriteLine("Большее число " + (max));
*/