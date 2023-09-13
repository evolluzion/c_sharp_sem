int N = 10;
PrintNaturalNumbers(N);

void PrintNaturalNumbers(int N)
{
    if (N < 1)
    return;
    Console.Write(N + " ");
    PrintNaturalNumbers(N - 1);
}