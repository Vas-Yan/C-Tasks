// Найти максимальное из трех чисел
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue,maxValue);
}
int [] A  = new int [3];
int index = 0;
while(index<A.Length)
{
    A[index]=GetRandom(-1,999);
    index++;
}
index = 0;
while(index<A.Length)
{
    Console.WriteLine(A[index]);
    index++;
}
index=0;
int max = 0;
while (index<A.Length)
{
    max=A.Max();
    index++;
}
index=0;
Console.WriteLine();
Console.WriteLine(max);

