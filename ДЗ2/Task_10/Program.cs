﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int namber = int.Parse(Console.ReadLine());
//bool isParse = int.TryParse(Console.ReadLine(), out int namber);
//if (isParse == false)
//{
  //  Console.WriteLine("Ошибка");
    //return;
//} else {
double namber2 = (namber%100 - namber%10)/10;
Console.WriteLine("Вторая цифра числа  - " + namber2);
//}
