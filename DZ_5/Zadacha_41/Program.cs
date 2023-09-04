Console.WriteLine("Введите элементы массива через пробел:");
string[] input = Console.ReadLine().Split(' ');

int[] numbers = new int[input.Length];

for (int i = 0; i < input.Length; i++)
{
    bool success = Int32.TryParse(input[i], out numbers[i]);

    if (!success)
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целые числа.");
        return;
    }
}

int count = CountNumbersGreaterThanZero(numbers);
Console.WriteLine("Количество чисел, больше нуля: " + count);

int CountNumbersGreaterThanZero(int[] numbers)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }

    return count;
}

/* ВТОРОЙ ВАРИАНТ ВВОДА ЧИСЕЛ

int count = ReadNumbersAndCountPositive();
Console.WriteLine("Количество чисел больше 0: " + count);

int ReadNumbersAndCountPositive()
{
    Console.WriteLine("Введите числа через пробел (для завершения введите 'q'): ");
    string input = Console.ReadLine();

    int positiveCount = 0;

    string[] numbers = input.Split(' ');

    foreach (string number in numbers)
    {
        if (int.TryParse(number, out int parsedNumber) && parsedNumber > 0)
        {
            positiveCount++;
        }
    }

    return positiveCount;
}
*/

/* ТРЕТИЙ ВАРИАНТ ЧЕРЕЗ ВВОД КАЖДОГО ЧИСЛА "М"

Console.WriteLine("Задайте, какое количество чисел вы будете вводить: ");
int M = int.Parse(Console.ReadLine());
int count = CountPositiveNumbers(M);
Console.WriteLine("Количество чисел больше 0: " + count);

int CountPositiveNumbers(int count)
{
    int positiveCount = 0;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("Введите число " + (i + 1) + ": ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            positiveCount++;
        }
    }

    return positiveCount;
} 
*/