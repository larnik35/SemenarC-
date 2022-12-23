// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

try
{
    Console.Clear();
    int m = ReadNamber("Введите номер строки массива \"m\"  - ");
    int n = ReadNamber("\nВведите номер столбца в массивеv \"n\"  - ");
    string elem = " ";
    int[,] array = new int[5, 5];
    Console.WriteLine();
    FillingPrintArray(array);
    Console.WriteLine($"\n Число в {m} сторке {n} столбце -  " + PrintingElementPosition(array, m, n, elem));
    Console.WriteLine("\nДля выхода нажми Ввод");
    string exit = Console.ReadLine(); // Делаю чтоб посмотреть результат работы в exe файле  
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    string exit = Console.ReadLine();
}

int ReadNamber(string input)
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
            array[i, j] = rnd.Next(0, 10);
            {
                Console.Write($" {array[i, j]}");
            }
        }
        Console.WriteLine();
    }
}

string PrintingElementPosition(int[,] array, int m, int n, string elem)
{

    if (m > array.GetLength(0) | m <= 0 | n > array.GetLength(1) | n <= 0)
    {
        elem = " Элемена с заданами параметрами не существует ";
    }
    else
    {
        elem = array[m - 1, n - 1].ToString();
    }
    return elem;
}
