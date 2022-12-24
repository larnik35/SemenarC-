// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

try
{
    Console.Clear();
    int m = ReadNamber("Введите колличество строк массива \"m\"  - ");
    int n = ReadNamber("\nВведите колличество столбцов в массивеv \"n\"  - ");
    int[,] array = new int[m, n];
    Console.WriteLine();
    FillingPrintArray(array);
    ArithmeticMeanArray(array);
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
        Console.Write("     ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            Console.Write($"  {array[i, j]}");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanArray(int[,] array) // принемаем заданный массив находим сумму  каждого столбца и распечатываем ее
{

    int sum = 0;
    Console.Write("Сумма");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($" {sum}");
        sum = 0;
    }
    Console.WriteLine();
}
