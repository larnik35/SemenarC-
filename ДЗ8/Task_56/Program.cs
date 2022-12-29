//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

try
{
    Console.Clear();
    int m = ReadNamber("Введите колличество строк массива \"m\"  - ");
    int n = ReadNamber("\nВведите колличество столбцов в массивеv \"n\"  - ");
    int[,] array = new int[m, n];
    int[] stringarray = new int[m];
    Console.WriteLine();
    Console.WriteLine("Сформированный массив");
    FillingPrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Ссумы строк массива"); /// Вывел чтоб можно было проконтроллировать 
    FindingSumRowsArray(array, stringarray);
    Console.WriteLine("        Номер строки с минимальной суммой = " + (FillingSum(stringarray)));

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

void FindingSumRowsArray(int[,] array, int[] stringarray) // Формируем массив из сумм строк расчетного массива 
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        stringarray[i] = sum;
        Console.Write($"  {stringarray[i]}");
        sum = 0;
    }
}

string FillingSum(int[] stringarray) // вычисляют минимальное значение
{
    int minindex = 0;
    int min = stringarray[0];
    string stringmin = " ";
    string minindexs = " ";
    for (int i = 0; i < stringarray.Length - 1; i++)
    {
        if (min == stringarray[i + 1]) // если несколько минимальных то первое
        {
            continue;
        }
        else if (min < stringarray[i + 1])
        {
            continue;
        }
        else
        {
            min = stringarray[i + 1];
            minindex = i + 1;
        }
    }
    for (int j = minindex + 1; j < stringarray.Length; j++) // ищет индексы минимальных если их несколько
    {
        if (min == stringarray[j])
        {
            stringmin =  stringmin + $", {j + 1}";
        }
    }



    minindexs = $" {minindex + 1}" + stringmin;
    return minindexs;
}