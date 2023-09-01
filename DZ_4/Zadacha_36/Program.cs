int[] array = GenerateRandomArray(10);
Console.WriteLine("Случайный массив:");
PrintArray(array);
int sum = SumOddPositions(array);
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);

int[] GenerateRandomArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(1, 10);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

int SumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    
    return sum;
}