// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int rem = 0;
int namber1 = 0;
int namber2 = 0;

bool isPars = int.TryParse(Console.ReadLine(), out int namber);
if (isPars == false) // проверка на ввод чисел
{
   Console.WriteLine("Вводите числа"); 
   return;
} 
if ((namber - 10000) < 0 || (100000 - namber) < 0 ) // проверка на пятизначность
{
    Console.WriteLine("Число не пятизначное");
    return;
}
namber1 = namber;
for (int i = 0; i < 5; i++)
{
   rem = namber1 % 10; // выделение воследней цифры числа
   namber1 = (namber1 - rem)/10; // формирование основы для выделения последующих цифр числа
   namber2 = namber2 * 10 + rem; // формирование разворота числа
}
Console.WriteLine("Разварот числа " + namber2);
if (namber == namber2)
{
    Console.WriteLine("число является пaлиндромом");
}
else
{
    Console.WriteLine("число не является пaлиндромом");
}

