//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
int[,,] array3D = new int[2, 2, 2];
int[] arraykey = new int[90];

CreatingKey(arraykey);
Console.WriteLine("Сформированный массив");
FillingPrintArray3D(array3D, arraykey);
Console.WriteLine("\nОставшиеся цифры");
PrintgKey(arraykey);


void CreatingKey(int[] arraykey) // создаем базу данных двузначных не повторяющихся чисел привязанных к индификатору (Номер ячейки массива)
{
    for (int i = 0; i < arraykey.Length; i++)
    {
        arraykey[i] = 10 + i;
        //  Console.Write($" {arraykey[i]}");
    }
}
void FillingPrintArray3D(int[,,] array3D, int[] arraykey) // заполняем массив 
{
    Random rnd = new Random();
    int index = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int d = 0; d < array3D.GetLength(2); d++)
            {
                while (arraykey[index] == 0) // Формируем рандомно индекс баззы данных чисел и проверяем пустая она или нет (есть цифра или 0  )
                {
                    index = rnd.Next(0, 90);
                }
                array3D[i, j, d] = arraykey[index]; // Если есть цифра то заносим ее в ячейку
                arraykey[index] = 0; // Обнуляем забранную ячейку т.к. данные забрали (цифру). 
                Console.Write($"{array3D[i, j, d]} ({i}, {j}, {d}) ");
            }
            Console.WriteLine("");
        }
    }
}

void PrintgKey(int[] arraykey) // Печатаем оставшиеся числа в баззе данных 
{
    for (int i = 0; i < arraykey.Length; i++)
    {
        Console.Write($"  {arraykey[i]}");
    }
}