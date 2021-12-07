// Дан целочисленный двумерный массив, размерности n х m. 
// Найти сумму и произведение всех элементов массива.
int GetRandom (int MinValue, int MaxValue)
{
    return new Random().Next(MinValue, MaxValue);
}
int N = GetRandom(1,10);
Console.WriteLine("# of rows ->" + N);
int M = GetRandom(1,10);
Console.WriteLine("# of columns ->" + M);
int [,] Matrix = new int [N,M];
void SetMatrix (int [,] Matrix)
{
    for (int i = 0; i<Matrix.GetLength(0); i++)
    {
        for (int j = 0; j<Matrix.GetLength(1); j++)
        {
            Matrix[i,j] = GetRandom(1,9);
        }
    }
}
void PrintMatrix (int [,] Matrix)
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
/* int SumOfMatrixElements (int [,] a)
{
    int sum = 0;
    for (int i = 0; i<Matrix.GetLength(0); i++)
    {
        for (int j = 0; j<Matrix.GetLength(1); j++)
        {
            sum += Matrix[i,j];
        }
    }
  Console.WriteLine(sum);
  return sum;
}
int ProductOfMatrixElements (int [,] a)
{
    int product = 0;
    for (int i = 0; i<Matrix.GetLength(0); i++)
    {
        for (int j = 0; j<Matrix.GetLength(1); j++)
        {
            product *= Matrix[i,j];
        }
    }
  Console.WriteLine(product);
  return product;
} */
SetMatrix(Matrix);
PrintMatrix(Matrix);
/* Console.WriteLine();
SumOfMatrixElements(Matrix);
ProductOfMatrixElements(Matrix); */