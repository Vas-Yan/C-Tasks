// Найти расстояние между точками в пространстве 2D/3D
int GetRandom(int MinValue, int MaxValue)
{
    return new Random().Next(MinValue, MaxValue);
}
double Point (double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)));
}
double x1 = GetRandom(0,100);
double x2 = GetRandom(0,100);
double y1 = GetRandom(0,100);
double y2 = GetRandom(0,100);

Console.Write($"x1,y1 = ({x1}; {y1}) x2,y2 = ({x2}; {y2})");
Console.WriteLine();
Point (x1,x2,y1,y2);
Console.WriteLine($"distance 2D = {Point (x1,x2,y1,y2)}");

double Point3D(double a1, double b1, double a2, double b2, double z1, double z2)
{
    return Math.Sqrt((Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2) + Math.Pow(z2 - z1, 2)));
}
double a1 = GetRandom(0, 100);
double a2 = GetRandom(0, 100);
double b1 = GetRandom(0, 100);
double b2 = GetRandom(0, 100);
double z1 = GetRandom(0, 100);
double z2 = GetRandom(0, 100);

Console.Write($"a1,b1,z1 = ({a1}; {b1}; {z1}) a2,b2 = ({a2}; {b2}; {z2})");
Console.WriteLine();
Console.WriteLine($"distance 3D = {Point3D(a1, a2, b1, b2, z1, z2)}");