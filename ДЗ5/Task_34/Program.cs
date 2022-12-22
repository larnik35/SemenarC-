// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.Write(" Введите длинну массива  ");
int a = int.Parse(Console.ReadLine());
int[] array = new int [a];
FillArrey (array);
PrintArray(array);
CalculationEven(array);

void CalculationEven(int[] array){
int sum = 0;
int b = 0;
for (int i = 0; i < array.Length; i++)
{
    b = array[i] % 2;
    if (b == 0)
    {
       sum = sum + 1; 
    }
}
Console.WriteLine(" Колличество четных чисел = " + sum);
}

void FillArrey (int[] array){
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,1000);
}
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
   Console.Write(array[array.Length-1]);
    Console.Write("]");
}
