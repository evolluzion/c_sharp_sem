double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };
double minValue = FindMinValue(numbers);
double maxValue = FindMaxValue(numbers);
double difference = maxValue - minValue;
Console.WriteLine("Разница между минимальным и максимальным элементами: " + difference);

double FindMinValue(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}

double FindMaxValue(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}