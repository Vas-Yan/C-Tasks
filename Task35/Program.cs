// Определить, присутствует ли в заданном массиве, некоторое число 
int NewRandom (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int [] A = new int [12];
void GetArray (int [] A)
{
    for (int i=0; i<A.Length; i++)
    {
        A[i]= NewRandom(-100,100);
    Console.Write($"{A[i]}  ");
    }
}
GetArray(A);
Console.WriteLine();
Console.WriteLine ("укажите число");
int s = Convert.ToInt32(Console.ReadLine());
string Find(int [] A)
{
    int count = A.Length;
    string Result = "числа нет";
    for (int i=0; i<count; i++)
    {
        if (A[i]==s) Result = "число есть";
    }

    return Result;
}
Console.WriteLine(Find (A)); 
