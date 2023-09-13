int M = 1;
int N = 15;
Console.WriteLine($"Сумма элементов от {M} до {N}: {SumNaturalNumbers(M, N)}");

int SumNaturalNumbers(int M, int N)
{
    if (M == N)
        return M;
    
    return N + SumNaturalNumbers(M, N - 1);
}