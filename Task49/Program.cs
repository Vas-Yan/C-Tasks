// See https://aka.ms/new-console-template for more information
int GetRandom (int MinValue, int MaxValue)
{
    return new Random().Next(MinValue, MaxValue);
}
int N = GetRandom(1,10);
Console.WriteLine("# of rows ->" + N);
int M = GetRandom(1,10);
Console.WriteLine("# of columns ->" + M);
double [,] Matrix = new double [N,M];
void SetMatrix (double [,] Matrix)
{
    for (int i = 0; i<Matrix.GetLength(0); i++)
    {
        for (int j = 0; j<Matrix.GetLength(1); j++)
        {
            Matrix[i,j] = GetRandom(1,9);
        }
    }
}
void PrintMatrix (double [,] Matrix)
{
    for (int i = 0; i<Matrix.GetLength(0); i++)
    {
        for (int j = 0; j<Matrix.GetLength(1); j++)
        {
            Console.Write($"{Matrix[i,j],5}  ");
        }
        Console.WriteLine();
    }
}
SetMatrix(Matrix);
PrintMatrix(Matrix);