int[,] matrix = new int[4, 4];
FillSpiral(matrix, 4, 4);
PrintArray(matrix, 4, 4);

void FillSpiral(int[,] matrix, int rows, int cols)
{
    int value = 1;
    int startRow = 0, startCol = 0;

    while (startRow < rows && startCol < cols)
    {
        for (int i = startCol; i < cols; i++)
        {
            matrix[startRow, i] = value++;
        }
        startRow++;

        for (int i = startRow; i < rows; i++)
        {
            matrix[i, cols - 1] = value++;
        }
        cols--;

        if (startRow < rows)
        {
            for (int i = cols - 1; i >= startCol; i--)
            {
                matrix[rows - 1, i] = value++;
            }
            rows--;
        }

        if (startCol < cols)
        {
            for (int i = rows - 1; i >= startRow; i--)
            {
                matrix[i, startCol] = value++;
            }
            startCol++;
        }
    }
}

void PrintArray(int[,] matrix, int rows, int cols)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}