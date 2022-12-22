// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
//Console.WriteLine("Введите длинну массива M");
//int M = int.Parse(Console.ReadLine());
//int[] array = new int[M];
//EnterArrey(array);

Console.WriteLine("Введите числа массива через пробел");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Console.Write("\nВведенный массив - ");
PrintArray(arr);
int s = FindSumPositiveNambers(arr);
Console.WriteLine($"Колличество положительных элементов в массиве = {s}");


/*
void EnterArrey(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\nВведите  {i + 1}-й элемент массиа - ");
        array[i] = int.Parse(Console.ReadLine());
    }
}
*/

void PrintArray(int[] array)
{
    Console.Write(" [");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int FindSumPositiveNambers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum = sum + 1;
        }

    }
    return sum;

}

