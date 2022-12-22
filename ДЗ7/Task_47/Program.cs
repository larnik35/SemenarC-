//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("ВВедите колличество столбцов массива m ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество строк в массиве n ");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];
FillingPrintArray(array);


void FillingPrintArray(double[,] array) // задаем и распечатываем массив с случайными числами
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * rnd.Next(-9, 10);
            Console.Write($" {array[i, j]:F1}");
        }
        Console.WriteLine();
    }

}
