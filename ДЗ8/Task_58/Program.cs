//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

try
{
    Console.Clear();
    int m1 = ReadNamber("Введите колличество строк 1 массива \"m\"  - ");
    int n1 = ReadNamber("\nВведите колличество столбцов 1 массива \"n\"  - ");
    int m2 = ReadNamber("\nВведите колличество строк 2 массива \"m\"  - ");
    int n2 = ReadNamber("\nВведите колличество столбцов 2 массива \"n\"  - ");
    if (n1 != m2) // проверка на возможность перемножить матрицы
    {
        Console.WriteLine("Такие матрицы испоьзовать нельзя");
        return;
    }

    int[,] array1 = new int[m1, n1];
    int[,] array2 = new int[m2, n2];
    int[,] productarray = new int[m1, n2];

    Console.WriteLine("\nСформированный массив №1");
    FillingPrintArray(array1);
    Console.WriteLine("\nСформированный массив №2");
    FillingPrintArray(array2);
    ProductArrays(array1, array2, productarray);
    Console.WriteLine("\nРезультат перемножение двух массивов");
    PrintArray(productarray);

    Console.WriteLine("\nДля выхода нажми Ввод");// Делаю чтоб посмотреть результат работы в exe файле
    string exit = Console.ReadLine();
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    string exit = Console.ReadLine();
}

int ReadNamber(string input) // Проверяем правильность ввода.
{
    Console.Write(input);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed == true)
    {
        return number;
    }
    throw new Exception("\nНужно вводить цифры. \n\nДля выхода нажмите ввод");
}

void FillingPrintArray(int[,] array) // задаем и распечатываем массив с случайными числами
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            Console.Write($"    {array[i, j]}");
        }
        Console.WriteLine();
    }
}

void ProductArrays(int[,] array1, int[,] array2, int[,] productarray)

{

    for (int i = 0; i < productarray.GetLongLength(0); i++)
    {
        for (int j = 0; j < productarray.GetLongLength(1); j++)
        {
            for (int d = 0; d < productarray.GetLongLength(0); d++)
            {
                productarray[i, j] = productarray[i, j] + array1[i, d] * array2[d, j];
            }
        }
    }
}

void PrintArray(int[,] array) // задаем и распечатываем массив с случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}");
        }
        Console.WriteLine();
    }
}