//Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива
int NewRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int [] A = new int [12];
int i = 0;
for(i=0; i<A.Length; A[i]=NewRandom(0,9), Console.WriteLine (A [i]), i++);
int sum = 0;
for (i = 0; i <A.Length; i++)
{
    sum = sum + A[i];
}
Console.WriteLine($"\n {sum}");