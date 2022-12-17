// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Console.Write(" Введите длинну массива  ");
int a = int.Parse(Console.ReadLine());
int[] array = new int[a];
FillArrey(array);
PrintArray(array);
DifferenceBetweenMaxMin(array);

void DifferenceBetweenMaxMin(int[] array)
{
    int dif = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($" Максимальное число {max}");
    Console.WriteLine($" Минимальное число {min}");
    dif = max - min;
    Console.WriteLine($" Разница между max и min  = {dif}");
}

void FillArrey(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    Console.Write(" [");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}
