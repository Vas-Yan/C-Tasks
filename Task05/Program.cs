// Написать программу вычисления значения функции y=f(a)
double F ( double  a)
{
   double y = Math.Pow(a,2) + 3*a-4;
    return y;
}
double a = new Random().Next(1,10);
Console.WriteLine(a);
Console.WriteLine(F(a));

