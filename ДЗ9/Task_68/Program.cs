//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Для вычесления функции Аккермана");
Console.Write("Введите значение M  ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N  ");
int n = int.Parse(Console.ReadLine());
long f = 0;
if (m < 1 | n < 0) // Проверка на положительные вводимые значения
{
    Console.WriteLine("Функция Аккермана принимает только положительные значения");
}
else
{
    Console.WriteLine($"\nФункция Аккермана для чисел {m} до {n}  = " + OutputFunctionAckerman(m, n));
}



long OutputFunctionAckerman(long m, long n) // Вычисляем функцию Аккермана
{
    
    if (m == 0)
    {
        f = n + 1;
    }
    else if (m > 0 && n == 0)
    {
        f = OutputFunctionAckerman(m - 1, 1);
    }
    else
    {
        f = OutputFunctionAckerman(m - 1, OutputFunctionAckerman(m, n - 1));
    }
    return f;
}


