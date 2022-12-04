// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите день недели (1,2, и.т.д.");
bool isParse = int.TryParse(Console.ReadLine(), out int day);

if (isParse == false) // Проверка на ввод цифр
{
   Console.WriteLine("Вводите цифра");
    return;
} 
if (day > 7)
{
   Console.WriteLine("В недели только 7 дней"); // Проверка на колличество дней
   return;
}

else {
if (day == 7 || day == 6)
{
    Console.WriteLine("Ура, это выходной");
}
else
{
  Console.WriteLine("( это рабочий день");  
}

}
