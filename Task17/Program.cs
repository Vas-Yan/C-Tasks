// По двум заданным числам проверять является ли одно квадратом другого
int A = new Random().Next(11,100);
Console.WriteLine("A = "+A);
int B = new Random().Next(1,10);
Console.WriteLine("B = "+B);
if(Math.Sqrt(B)==A)
{
    Console.WriteLine("B is a square of A");
}
else
{
    Console.WriteLine("B is NOT a square of A");
} 
if(B==Math.Sqrt(A))
{
    Console.WriteLine("A is a square of B");
}
else
{
    Console.WriteLine("A is NOT a square of B");
} 