var array = GenArray();
Console.WriteLine("Исходный массив:");
PrintArray(array);
int minSumRowIndex = GetRowWithMinSum(array);
Console.WriteLine($"Номер строки с минимальной суммой элементов: {minSumRowIndex}");

int[,] GenArray(int rows = 6, int cols = 5)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 50);
        } 
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int GetRowWithMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRowIndex = i + 1; //Добавил +1, иначе программа считает 1 строку строкой с индексом 0.
        }
    }

    return minSumRowIndex;
}