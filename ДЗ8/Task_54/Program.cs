//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

try
{
    Console.Clear();
    int m = ReadNamber("Введите колличество строк массива \"m\"  - ");
    int n = ReadNamber("\nВведите колличество столбцов в массивеv \"n\"  - ");
    int[,] array = new int[m, n];
    Console.WriteLine();
    Console.WriteLine("Заданный массив");
    FillingPrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Сортированный массив");
    SortingArray(array);
    PrintArray(array);

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
            Console.Write($"   {array[i, j]}");
        }
        Console.WriteLine();
    }
}

void SortingArray(int[,] array) // Сорти по убыванию.
{
    int i2 = 0;
    int j2 = 0;
    int max = 0;
    for (i2 = 0; i2 < array.GetLength(0); i2++)
    {

        for (j2 = 0; j2 < array.GetLength(1); j2++) // Меняем начала сравнение на -1 таткак в первом индексе уже макс число из строки . 
                                                    // Находим следующее максимальное число.
        {
            max = array[i2, j2];                                                 // Обозначаем максимальное число первым числом в массиве 
            for (int indexj2 = j2 + 1; indexj2 < array.GetLength(1); indexj2++) 
            {
                if (max < array[i2, indexj2])                   // Сравниваем следующее число в строке массива( второе итд) +1 с максимальным
                {
                    array[i2, j2] = array[i2, indexj2];           // Если число больше его значение пишем в индекс первого элемента 
                    array[i2, indexj2] = max;                    // В индекси найденного максимального на этой этерации вписываем предыдущий максимум
                    max = array[i2, j2];  // в максимум записываем новое  найденное найденное значение максимального числа.
                }
            }  // переходим к сравнению следующего числа в строке . В индекс первого элемента записано максимальное число в строке массива

        }
    }
}


void PrintArray(int[,] array) //  распечатываем массив 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"   {array[i, j]}");
        }
        Console.WriteLine();
    }
}

