// Удалить вторую цифру трёхзначного числа
int A = new Random().Next(100,999);
Console.WriteLine(A);
int FirstDigit = A/100;
int SecondDigit = A%100/10;
int ThirdDigit = A%10;
Console.Write(FirstDigit);
Console.Write(ThirdDigit);