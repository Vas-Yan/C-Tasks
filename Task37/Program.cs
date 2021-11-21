// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int [] A = new int [123];
void Array (int [] A)
{
    for(int i = 0; i<A.Length;i++)
    {
    A [i]= GetRandom(0,100);
    Console.Write($"{A[i]}; ");
    }
}
Array(A);
Console.WriteLine();
int NumbersCount(int [] A)
{
    int count = 0;
    for(int j=0; j<A.Length; j++)
    {
        if (A[j]>=10 & A[j]<=99) count++;
    }
    return count;
}

Console.WriteLine(NumbersCount(A));