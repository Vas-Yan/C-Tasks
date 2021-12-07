// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int FillArray (int [] Array)
{   
    int Result = 0;
    for (int k=0; k<Array.Length; k++)
    {
        Array[k]= Result + k;
        Console.Write(Array[k]+ "; ");
    }
    return Result;
}
int ProductOfParedNumbers (int [] Array)
{
    int Product = 0;
    int [] Array2 = new int [Array.Length];
    int j = 0;
    for (int i=0; i<Array.Length; i++, j++)
    {   
        if (j==Array.Length/2) break;
        Product = Array[i]*Array[Array.Length-i-1];
        Array2[j]=Product;
        Console.Write(Array2[j]+ "; ");
    }
    return Array2[j];
}

int [] Array = new int [10];
FillArray(Array);
Console.WriteLine();
ProductOfParedNumbers(Array);

