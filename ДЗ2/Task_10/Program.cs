//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int namber = int.Parse(Console.ReadLine());
double namber2 = (namber%100 - namber%10)/10;
Console.WriteLine("Вторая цифра числа  - " + namber2);

