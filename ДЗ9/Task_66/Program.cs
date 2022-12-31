//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите значение M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine());
int sum =0;
Console.WriteLine($" Сумма натуральных чисел от {m} до {n}  = " + OutputSumNamber(m, n));

int OutputSumNamber( int i, int c)
{    sum = sum +i;

    if (i < c)
    {
        OutputSumNamber(i + 1,  c);
    }
return sum;
}
