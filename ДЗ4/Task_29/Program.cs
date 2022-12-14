// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
FillArrey (array);
PrintArray(array);



void FillArrey (int[] array){
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,10);
}
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]); // вывод последнего элемента массива
    Console.Write("]");
}