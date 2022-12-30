//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


try
{
    Console.Clear();
    int m = ReadNamber("Введите колличество строк массива \"m\"  - ");
    int n = ReadNamber("\nВведите колличество столбцов в массивеv \"n\"  - ");
    int[,] array = new int[m, n];
    int j = 0;
    int i = 0;
    int h = 1;
    Console.WriteLine();



    Console.WriteLine("\nСформированный спиральный  массив");
    FillingSpiralArray(array, m, n);
    PrintArray(array);



    Console.WriteLine();
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

void FillingSpiralArray(int[,] array, int m, int n)
{

    int namber = 1;
    int i = 0;
    int j = 0;

    while (namber <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = namber;
        namber++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}








