//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write(" Введите длинну массива  ");
int a = int.Parse(Console.ReadLine());
int[] array = new int [a];
FillArrey (array);
PrintArray(array);
CalculationSum(array);

void CalculationSum(int[] array){
int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
     sum = sum + array[i];     
}
Console.WriteLine(" Сумма нечетных = " + sum);
}

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
   Console.Write(array[array.Length-1]);
    Console.Write("]");
}
