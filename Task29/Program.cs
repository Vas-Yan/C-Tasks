// Написать программу вычисления произведения чисел от 1 до N
int GetRandomNumber (int MinValue, int MaxValue)
{
    return new Random().Next(MinValue,MaxValue);
}
int N = GetRandomNumber (1,27);
double Product (int N)
{
    double result = 1;
    for (int i=1; i<=N; i++)
    {
        result = result*i;
    }
    return result;
}
Product(N);
Console.WriteLine(N);
Console.WriteLine(Product(N));