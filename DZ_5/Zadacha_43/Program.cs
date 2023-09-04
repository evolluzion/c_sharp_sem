double k1, b1, k2, b2;

Console.WriteLine("Введите значения b1, k1, b2 и k2 через пробел:");
string[] input = Console.ReadLine().Split(' ');

bool success = Double.TryParse(input[0], out b1);
success &= Double.TryParse(input[1], out k1);
success &= Double.TryParse(input[2], out b2);
success &= Double.TryParse(input[3], out k2);

if (!success)
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа.");
    return;
}

double x = FindIntersectionX(k1, b1, k2, b2);
double y = CalculateY(x, k1, b1);

Console.WriteLine("Точка пересечения: (" + x + ", " + y + ")");


double FindIntersectionX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double CalculateY(double x, double k, double b)
{
    return k * x + b;
}