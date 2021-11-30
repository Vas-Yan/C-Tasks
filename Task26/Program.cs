// Возведите число А в натуральную степень B используя цикл
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue,maxValue);
}
int A = GetRandom(1,10);
Console.WriteLine ($"число А = {A}");
int B = GetRandom (1,10);
Console.WriteLine($"число B = {B}");
double Exponentiation (int A)
{
    double result = 0;
    for (int i=0; i<=B; i++)
    {
        result = Math.Pow(A,B);
    }
    return result;
}

Console.WriteLine($"число A в степени B = {Exponentiation(A)}");
