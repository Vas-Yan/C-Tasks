// Найти кубы чисел от 1 до N
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue,maxValue);
}
int N = GetRandom(1,10);
Console.WriteLine(N);
void TableOfCubes (int N)
{
    for (int i = 1; i<=N; i++)
    Console.WriteLine($"куб числа {i} = {i*i*i}");
}
TableOfCubes(N);