// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 1-е число");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
double b = Convert.ToDouble(Console.ReadLine());

if (a > b) Console.WriteLine("Больше 1-е число");
if (a < b) Console.WriteLine("Больше 2-е число");
    else  Console.WriteLine("Они равны");
