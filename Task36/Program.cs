// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int [] A = new int [12];
for (int i=0; i<A.Length; A[i]=GetRandom (100, 1000), Console.Write($"{A[i]}; "), i++);
Console.WriteLine();
int CountOdd (int [] A)
{
    int countO = 0;
    for(int j=0; j<A.Length; j++)
    {
        if (A[j]%2>0) countO++;
    }
    return countO;
}
Console.WriteLine(CountOdd(A));
int CountEven (int [] A)
{
    int countE = 0;
    for(int k=0; k<A.Length; k++)
    {
        if (A[k]%2==0) countE++;
    }
    return countE;
}
Console.WriteLine(CountEven(A));
