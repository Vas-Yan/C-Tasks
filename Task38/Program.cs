//  Найти сумму чисел одномерного массива стоящих на нечетной позиции
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int [] A = new int [10];
for (int i=0; i<A.Length; A[i]=GetRandom(-1000,1000), Console.Write($"{A[i]}; "), i++);
int SumOddNumbers (int [] A)
{
    int sum = 0;
    for (int j=0; j<A.Length; j++)
    {
        if (j%2==0) sum = sum + A[j];
    }
    return sum;
}
Console.WriteLine();
Console.WriteLine(SumOddNumbers(A));