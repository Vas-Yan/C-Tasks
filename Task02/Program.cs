// Даны два числа. Показать большее и меньшее.
int GetRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int [] A = new int [2];
int index = 0;
while (index<A.Length) 
   {
       A[index]= GetRandom(0,100);
       index++;
   } 
index=0;
while (index<A.Length) 
{
    Console.WriteLine(A[index]);
    index++;
}
int max = A.Max();
 Console.WriteLine();
 Console.Write("max = "+max);

 int min = A.Min();
 Console.WriteLine();
 Console.Write("min = "+ min);