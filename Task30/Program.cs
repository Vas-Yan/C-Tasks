// Показать кубы чисел, заканчивающихся на четную цифру
int GetRandomNumber   (int MinValue, int MaxValue)
{
    return new Random().Next(MinValue, MaxValue);
}
int N = GetRandomNumber(0,100);
int [] Array = new int [N];
void FillArray (int [] Array)
{
    for (int i=1; i<Array.Length; i++)
    {
        if(Math.Pow(i,3)%2==0)
        {
            Console.WriteLine($"куб числа {i} = {Math.Pow(i,3)}");
        }
    }
}
FillArray(Array);