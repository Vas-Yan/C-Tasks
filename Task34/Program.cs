// Написать программу замену элементов массива на противоположные
int GetRandom (int minValue, int maxValue)
{
   return new Random().Next(minValue, maxValue);
}
int [] A = new int [10];
int i =0;
for (i =0; i<A.Length; A[i] = GetRandom(-100,100), Console.WriteLine(A[i]), i++);
Console.WriteLine();
int [] ANew = new int [10];
i=0;
for (int j=0; j<ANew.Length; ANew[j]= A[i]*(-1), Console.WriteLine(ANew[j]), j++, i++);
