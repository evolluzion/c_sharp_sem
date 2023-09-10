int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = { { 3, 4 }, { 3, 3 } };
int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Невозможно умножить матрицы. Размерности не совпадают.");
    return;
}

MatrixMultiplication(resultMatrix);
Console.WriteLine("Результирующая матрица:");
PrintArray(resultMatrix);

void MatrixMultiplication(int[,] resultMatrix)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}