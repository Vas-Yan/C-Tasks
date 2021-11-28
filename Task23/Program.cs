// Показать таблицу квадратов чисел от 1 до N 
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue,maxValue);
}
void TableOfSquares (int N)
{   
    for (int j=1; j<=N; j++)
    {
        Console.WriteLine($"квадрат числа {j}={Math.Pow(j,2)}");
    }
}
int N=GetRandom(1,100);
Console.WriteLine($"число N -> {N}");
TableOfSquares(N);

/* for(int i=0; i<Array.Length; i++, ArrayConsole.WriteLine(Array[i]));

double TableOfSquares (int [] Array)
{
    double result = 0;
    for (int i = 0; i<Array.Length; i++)
    {
        result = Math.Pow (Array[i],2);
        result ++;
    }
    return result;
} 
Console.WriteLine(TableOfSquares(Array)); */