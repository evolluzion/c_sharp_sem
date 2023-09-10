int[, ,] array = GenerateArray();
PrintArray(array);

int[,,] GenerateArray()
{
    Random random = new Random();
    int[,,] array = new int[3, 3, 3];
    bool[] usedNumbers = new bool[100];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(10, 100);
                } while (usedNumbers[randomNumber - 10]);

                array[i, j, k] = randomNumber;
                usedNumbers[randomNumber - 10] = true;
            }
        }
    }

    return array;
}

void PrintArray(int[, ,] array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i}, {j}, {k})");
            }
        }
    }
}


/* 
ЕСЛИ ЗАДАВАТЬ ВРУЧНУЮ С УВЕЛИЧЕНИЕМ НА 1.

int size1 = 2;
int size2 = 2;
int size3 = 2;
int[,,] array = new int[size1, size2, size3];

GenArray(array);
PrintArray(array);

void GenArray(int[,,] array)
{
    int number = 10;
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                array[i, j, k] = number;
                number++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
            }
        }
    }
}
*/