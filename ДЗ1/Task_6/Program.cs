// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число");
double a = Convert.ToDouble(Console.ReadLine());
double d = 0;
if (a != 0) // Проверка на 0
{
    d = a % 2;
    if (d == 0) Console.WriteLine((a) + " - Число четное ");
    else Console.WriteLine((a) + " - Число не четное");
}
else Console.WriteLine((a) + " - Является 0");

