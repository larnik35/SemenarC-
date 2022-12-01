// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите 1-е число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (max > a ) max = max ;
   else max = a;
if (max > b) max = max ;
 else  max = b;
 if (max > c) max = max ;
 else  max = c;
Console.WriteLine("Максимальное число - " + (max));
