// Подсчитать сумму цифр в числе
int GetRandomNumber (int MinValue, int MaxValue)
{
    return new Random().Next(MinValue,MaxValue);
}
int Number = GetRandomNumber (0,1000);
Console.WriteLine(Number);
int CountSumOfDigits (int Number)
{
    int FirstDigit = Number/100;
    int SecondDigit = Number%100/10;
    int ThirdDigit = Number%10;
    int sum = FirstDigit + SecondDigit + ThirdDigit;
    return sum;
}
CountSumOfDigits(Number);
Console.WriteLine (CountSumOfDigits(Number));
