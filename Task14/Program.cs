// Найти третью цифру числа или сообщить, что её нет
int a = new Random().Next(0,999);
Console.WriteLine(a);
int ThirdDigit = a%10;
if(a>100)
{
    Console.WriteLine(ThirdDigit);
}
else
{
    Console.WriteLine("no 3d digit in the given number");
}