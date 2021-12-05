// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0
string Shape (int X, int Y)
{
    string result = string.Empty;
if(X>0&&Y>0) Console.WriteLine ("First quarter");
if(X<0&&Y>0) Console.WriteLine ("Second quarter");
if(X<0&&Y<0) Console.WriteLine ("Third quarter");
if(X>0&&Y<0) Console.WriteLine ("Forth quarter");
return result;
}
Console.WriteLine("insert number (-100,+100)");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("insert number (-100,+100)");
int Y = Convert.ToInt32(Console.ReadLine());
Shape (X,Y);
