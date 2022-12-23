//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


try
{
    Console.Clear();
    int m = ReadNamber("Введите колличество столбцов массива \"m\"  - ");
    int n = ReadNamber("\nВведите колличество строк в массивеv \"n\"  - ");
    double[,] array = new double[m, n];
    Console.WriteLine();
    FillingPrintArray(array);
    Console.WriteLine("\nДля выхода нажми Ввод");// Делаю чтоб посмотреть результат работы в exe файле
    string exit = Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    string exit = Console.ReadLine();
}



void FillingPrintArray(double[,] array) // задаем и распечатываем массив с случайными числами
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * rnd.Next(-9, 10);
            if (array[i, j] >= 0)
            {
                Console.Write($"  {array[i, j]:F1}"); // вставил лишний пробел если число положительное , 
                                                      //чтоб выровнить столбцы тк отр один знак больше
            }
            else
            {
                Console.Write($" {array[i, j]:F1}");
            }
        }
        Console.WriteLine();
    }
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