int[] numbers = GetNumbers();
Console.WriteLine("Элементы массива:");
PrintNumbers(numbers);

int[] GetNumbers()
{
    int[] numbers = new int[8];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numbers;
}

void PrintNumbers(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }

    Console.WriteLine();
}