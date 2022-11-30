// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 1-е число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) Console.WriteLine("Больше 1-е число - " + (a));
else if (a < b) Console.WriteLine("Больше 2-е число - " + (b));
     else  Console.WriteLine("Они равны");
