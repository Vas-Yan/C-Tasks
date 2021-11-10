// Выяснить является ли число чётным
int GetRandomNumber (int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}
int a = GetRandomNumber(-100,999);

Console.WriteLine(a); // <- выводим на консоль число, чтобы можно было проверить
if (a % 2 == 0) 
{
    Console.Write("число является четным");
}
    else
    {
        Console.Write("число является нечетным");

    }

