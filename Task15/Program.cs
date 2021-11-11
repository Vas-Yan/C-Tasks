// Дано число. Проверить кратно ли оно 7 и 23
int a = new Random().Next(1,999);
Console.WriteLine(a);
if(a%7==0 && a%23==0)
{
    Console.WriteLine("multiple of 7 and 23");
}
else
{
    Console.WriteLine("NOT a multiple of 7 and 23");
}