int[] array = GenerateRandomArray(10);
        
Console.WriteLine("Случайный массив:");
PrintArray(array);
        
int count = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел: {count}");

int[] GenerateRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
        
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }
        
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}