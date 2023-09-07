/* Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

var array = GenArray();
PrintArray(array);
System.Console.WriteLine(" ");
ChangeRows(array);
PrintArray(array);

void ChangeRows(int[,] array)
{
    int lastRow = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[lastRow, i];
        array[lastRow, i] = array[0, i];
        array[0, i] = temp;

    }

}


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
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
        
    }
}

*/


/*Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

var array = GenArray(5, 5);
PrintArray(array);
System.Console.WriteLine(" ");
ChangeArray(array);
PrintArray(array);


void ChangeArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[j, i] = array[i, j];
        } 
    }
}



int[,] GenArray(int rows = 5, int cols = 5)
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
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
        
    }
}
*/

/* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

var array = GenArray();
PrintArray(array);
Console.WriteLine();

Dictionary<int, int> dict = new Dictionary<int, int>();
for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (dict.ContainsKey(array[i, j]))
        {
            dict[array [i, j]]++;
        }
        else
        {
            dict.TryAdd(array[i, j], 1);
        }
    }
}

foreach (var item in dict)
{
    Console.WriteLine($"Элемент {item.Key} Количество {item.Value}");
}

int[,] GenArray(int rows = 5, int cols = 5)
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
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
        
    }
}

*/

//Другое решение через код без Dictionary:
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] rowAr=GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ",rowAr));
PrintData(rowAr);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
    int index=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i,j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i+1; j < inArray.Length; j++)
        {
            if(inArray[i]>inArray[j])
            {
                int k=inArray[i];
                inArray[i]=inArray[j];
                inArray[j]=k;
            }
        }
    }
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintData(int[] inArray)
{
    int el=inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[i]!=el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el=inArray[i];
            count=1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}