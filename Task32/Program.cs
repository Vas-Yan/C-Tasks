//  Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
int [] A = new int [8];
for(int i = 0; i<A.Length; Console.WriteLine(A [i]), i++);
Console.WriteLine();
for(int i = 0; i<A.Length; A[i] = 1, Console.WriteLine(A [i]), i++);