﻿// Определить количество цифр в числе
int CountDigit(int n)
{
    int k = 0;
    while (n!=0)
    {
        k++;
        n=n/10;
    }
    return k;
}
Console.WriteLine(CountDigit(1234));