// Задать массив из 8 элементов и вывести их на экран
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int [] A = new int [8];
int index = 0;
while (index<A.Length)
{
    A[index]= GetRandom(1,999);
    index++;
}
index = 0;
while(index<A.Length)
{
    Console.WriteLine(A[index]);
    index++;
}