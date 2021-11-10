// Показать четные числа от 1 до N

/* Console.WriteLine("Введите число >1");
int b;
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до N");
 
 int i=1;
 while (i< b)
 {
     if (i%2 == 0)
     {
         Console.Write(i+ "; ");
    
     }
      i++;
 } */

Console.WriteLine("введите число>1");
int b = Convert.ToInt32(Console.ReadLine());
int i = 0;
for (i=1; i<b+1;i++) if (i%2==0)
{
    Console.Write (i + "; ");
}  
