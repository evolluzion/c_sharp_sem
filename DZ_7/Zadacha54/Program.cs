
var array = GenArray();
Console.WriteLine("Исходный массив:");
PrintArray(array);
SortRows(array);
Console.WriteLine("\nУпорядоченный массив:");
PrintArray(array);

int[,] GenArray(int rows = 5, int cols = 6)
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

void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Создаем временный массив для хранения отсортированных элементов строки
        int[] sortedRow = new int[array.GetLength(1)];

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortedRow[j] = array[i, j];
        }

        // Сортируем временный массив по убыванию
        Array.Sort(sortedRow);
        Array.Reverse(sortedRow);

        // Копируем отсортированные элементы обратно в исходный массив
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = sortedRow[j];
        }
    }
}