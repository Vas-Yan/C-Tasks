// По двум заданным числам проверять, является ли первое квадратом второго
double a;
string s = Console.ReadLine();
a= Convert.ToInt32(s);
double b;
string d = Console.ReadLine();
b = Convert.ToInt32 (d);
if(Math.Pow(b,2)==a)
{
    Console.Write("Yes");
}
if((Math.Pow(b,2)!=a))  
{
    Console.Write("No");
    }