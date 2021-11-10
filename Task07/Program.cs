// Показать числа от -N до N

Console.WriteLine ("введите отрицательное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите положительное число");
int b = Convert.ToInt32(Console.ReadLine());
int count = (-a) + b;
for (int i =0; i<count+1; Console.Write(a+";"), a++, i++);
