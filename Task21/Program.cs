// Программа проверяет пятизначное число на палиндромом
int GetRandom (int MinValue, int MaxValue)
{
    return new Random().Next(MinValue, MaxValue);
}
int FiveDigitNumber = GetRandom(10000,100000);
Console.WriteLine(FiveDigitNumber);
void CheckForPolydrom (int FiveDigitNumber)
{ 
    int FirstDigit = FiveDigitNumber/10000;
    int SecondDigit = FiveDigitNumber/1000-FirstDigit*10;
    int FourthDigit = FiveDigitNumber%100/10;
    int FifthDigit = FiveDigitNumber%10;
    if(FirstDigit == FifthDigit && SecondDigit==FourthDigit) 
    {
        Console.WriteLine("polydrom is detected");
    }
    else
    {
    Console.WriteLine("Polydrom is NOT detected");
    }
}
CheckForPolydrom(FiveDigitNumber);