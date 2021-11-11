// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int A = new Random().Next(11,999);
Console.WriteLine(A);
Console.WriteLine();
int B = new Random().Next(1,10);
Console.WriteLine(B);
double Result = A/B;
double Excess = A-Result*B;
Console.WriteLine();
if(A%B==0) 
{
    Console.WriteLine("число кратно заданному");
}
else
{
    Console.WriteLine(Excess+ " <-- excess from devision");
}
