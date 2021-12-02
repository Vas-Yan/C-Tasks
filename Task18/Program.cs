// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool X = true;
bool Y = false;
bool FirstPart = !(X&&Y);
bool SecondPart = !X||!Y;
if(FirstPart == SecondPart)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}










/* int getTheHighestDigit (int a)
{int max = 0;
while (a !=0)
    {
        if(a%10>max) max = a % 10;
        a=a/10;
    }
return max;
}
int a = new Random().Next(10,99);
Console.WriteLine();
Console.Write(a+"<-- число");


Console.WriteLine();
Console.Write(getTheHighestDigit(a)+"<-- наибольшая цифра числа"); */