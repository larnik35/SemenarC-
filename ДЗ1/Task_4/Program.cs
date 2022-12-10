// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите 1-е число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (max > a ) return;
   else max = a;
if (max > b) return;
 else  max = b;
 if (max > c) return;
 else  max = c;
Console.WriteLine("Максимальное число - " + (max));
