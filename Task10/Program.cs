// Показать вторую цифру трёхзначного числа
int A = new Random().Next(100,999);
Console.WriteLine(A);
int ThirdDigit = A%100;
Console.WriteLine();
int SecondDigit = (ThirdDigit-ThirdDigit%10)/10;
Console.WriteLine(SecondDigit+" <- second digit");