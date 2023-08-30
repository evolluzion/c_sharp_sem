
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int power = Convert.ToInt32(Console.ReadLine());

int result = Power(number, power);

Console.WriteLine($"Результат: {result}");

int Power(int number, int power)
{
    int result = 1;

    for (int i = 0; i < power; i++)
    {
        result *= number;
    }

    return result;
}
