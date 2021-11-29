// Найти сумму чисел от 1 до А
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int A = GetRandom(1,10);
Console.WriteLine($"A = {A}");
int SumOfNumbers(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
       sum = sum + i;
    }
    Console.WriteLine($"сумма чисел от 1 до А = {sum}");
    return sum;
    
}
SumOfNumbers(A);
//Console.WriteLine($"сумма чисел от 1 до А = {SumOfNumbers(A)}");